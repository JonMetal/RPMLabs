using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using WpfItEquipment.Models;
using WpfItEquipment.Windows;

namespace WpfItEquipment.UTILS
{
    public class Storage
    {
        private SqlConnection GetSqlConnection() => new SqlConnection(DataBaseConstants.ConnectionString);

        public User GetUser(string login, string password)
        {
            using (SqlConnection sqlConnection = GetSqlConnection())
            {
                sqlConnection.Open();
                string sql = "SELECT [us_id], [us_password], [us_login], [ur_id] " +
                "FROM [USER] " +
                "WHERE [US_LOGIN] = @login " +
                "AND [US_PASSWORD] = @password ";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("login", login);
                cmd.Parameters.AddWithValue("password", password);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    User user = new User
                    {
                        Id = reader.GetInt32(0),
                        Password = reader.GetString(1),
                        Login = reader.GetString(2),
                        Role = (UserRole)reader.GetInt32(3)
                    };
                    return user;
                }
                //throw new Exception("Пользователь не найден. Проверьте правильность данных и повторите попытку входа.");
                string lol = sqlConnection.ConnectionString;
            }
            string lol2 = sqlConnection.ConnectionString;
            throw new Exception("Пользователь не найден. Проверьте правильность данных и повторите попытку входа.");
        }

        public void AddUser(string login, string password, int roleId)
        {
            using(sqlConnection)
            {
                sqlConnection.Open();
                string sql = "INSERT INTO [user] VALUES (@roleId, @login, @password)";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("roleId", roleId);
                cmd.Parameters.AddWithValue("login", login);
                cmd.Parameters.AddWithValue("password", password);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Equipment> GetEquipments()
        {
            using(sqlConnection)
            {
                sqlConnection.Open();
                List<Equipment> result = new();
                string sql = "SELECT * FROM [equipment]";
                SqlCommand cmd = new(sql, sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Equipment equipment = new Equipment
                    {
                        Id = reader.GetInt32(0),
                        Model = reader.GetString(1),
                        Type = (EquipmentType)reader.GetInt32(2)
                    };
                    result.Add(equipment);
                }
                return result;
            }
        }

        public void AddEquipment(string model, int type)
        {
            using(sqlConnection)
            {
                sqlConnection.Open();
                string sql = "INSERT INTO [equipment] VALUES (@model, @type)";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("model", model);
                cmd.Parameters.AddWithValue("type", type);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateEquipment(Equipment equipment)
        {
            using(sqlConnection)
            {
                sqlConnection.Open();
                string sql = "UPDATE [equipment] SET [eq_model] = @model, [et_id] = @type WHERE [eq_id] = @id";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("model", equipment.Model);
                cmd.Parameters.AddWithValue("type", (int)equipment.Type);
                cmd.Parameters.AddWithValue("id", equipment.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
