using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using My_List_v2.Models;


namespace My_List_v2.Repository
{
    public class WordRepositoryImp : IWordRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string DefaultConnection;
       

        public WordRepositoryImp(IConfiguration configuration)
        {
            _configuration = configuration;
            DefaultConnection = _configuration.GetConnectionString("DefaultConnection");
           
        }


        public async   Task<List<Word>> GetAllWords()
        {
            List<Word> words = new List<Word>();
            using (var conn = new SqlConnection(DefaultConnection))
            {
                 conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Words", conn);
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader reader =  cmd.ExecuteReader())
                {
                    while (  reader.Read())
                    {
                        Word word = new Word()
                        {
                            Id = Int32.Parse(reader["Id"].ToString()),
                            WordText = reader["Word"].ToString(),
                            Translation = reader["Translation"].ToString(),
                        };
                        words.Add(word);
                    }
                }

                return words;

            }
        }



        public async Task<bool> AddWord(Word word)
        {
            using (var conn = new SqlConnection(DefaultConnection))
            {
                 await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("INSERT INTO Words (Word, Translation) VALUES (@textWord ,@translate )", conn);
                cmd.Parameters.Add(new SqlParameter("@textWord", word.WordText));
                cmd.Parameters.Add(new SqlParameter("@translate", word.Translation));

                return await cmd.ExecuteNonQueryAsync() > 0;

            }
        }

        public List<Word> GetFourWordsForTestWords()
        {
            List<Word> words = new List<Word>();
            using (var conn = new SqlConnection(DefaultConnection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 4 Id,Word,Translation FROM Words ORDER BY NEWID()", conn);
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader reader =  cmd.ExecuteReader())
                {
                    while (  reader.Read())
                    {
                        Word word = new Word()
                        {
                            Id = Int32.Parse(reader["Id"].ToString()),
                            WordText = reader["Word"].ToString(),
                            Translation = reader["Translation"].ToString(),
                        };
                        words.Add(word);
                    }
                }
                return words;
            }
        }
        
        

        public void UpdateWord(Word word)
        {
            //TODO write update word
        }

        public Word GetRandomWord()
        {
            using (var conn = new SqlConnection(DefaultConnection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 Id,Word,Translation FROM Words ORDER BY NEWID()", conn);
                cmd.CommandType = CommandType.Text;
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    Word word = new Word()
                    {
                        Id = Int32.Parse(reader["Id"].ToString()),
                        WordText = reader["Word"].ToString(),
                        Translation = reader["Translation"].ToString(),
                    };

                    return word;
                }
            }
        }

        public async Task<bool> DeleteWordById(int id)
        {
            using (var conn = new SqlConnection(DefaultConnection))
            {
                
                 await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("DELETE FROM Words WHERE Id=@wordId", conn);
                cmd.Parameters.Add(new SqlParameter("@wordId", SqlDbType.Int) {Value = id});

                return await cmd.ExecuteNonQueryAsync() > 0;

            }
        }
        
       
      
        
    }
}