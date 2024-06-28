using CRUD_HAPPY_PET.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_HAPPY_PET.Repositories
{
    public class PetRepository : BaseRepository, IPetRepository
    {
        #region Constructor
        public PetRepository(string connection)
        {
            this.connectionString = connection;
        }
        #endregion

        #region Methods
        public void Add(Pet pet)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Pet pet)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pet> GotAll()
        {
            var petList = new List<Pet>();
            using (MySqlConnection connection = new(connectionString) )
            using (MySqlCommand command = new())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Pet ORDER BY Pet_Id DESC";

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Pet petModel = new()
                    {
                        PetId = (sbyte)reader[0],
                        PetName = reader[1].ToString(),
                        PetType = reader[3].ToString(),
                        PetColour = reader[2].ToString()
                    };
                    petList.Add(petModel);
                }
            }
            return petList;
        }

        public IEnumerable<Pet> GotByValue(string value)
        {
            var petList = new List<Pet>();
            sbyte petId = (sbyte)(sbyte.TryParse(value, out _) ? Convert.ToSByte(value) : 0);
            string petName = value;
            using (MySqlConnection connection = new(connectionString))
            using (MySqlCommand command = new())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Pet WHERE Pet_Id=@id OR Pet_Name LIKE  CONCAT(@name, '%') ORDER BY Pet_Id DESC";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = petId;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = petName;
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Pet petModel = new()
                    {
                        PetId = (sbyte)reader[0],
                        PetName = reader[1].ToString(),
                        PetType = reader[3].ToString(),
                        PetColour = reader[2].ToString()
                    };
                    petList.Add(petModel);
                }
            }
            return petList;
        }
        #endregion
    }
}
