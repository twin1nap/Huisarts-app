using ClassLibrarydB.model;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Sec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarydB
{
    public class data
    {
        string _connectionString;

        public data(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                Console.WriteLine("no or blank connection string");
            }
            else
            {
                _connectionString = connectionString;
            }
        }

        public List<SmallPatiënt> GetAllPatiënts()
        {
            List<SmallPatiënt> patiënten = new List<SmallPatiënt>();
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = @"
                SELECT patiënten.id, `voornaam`, `achternaam`, `postcode`, `plaats`,  COUNT(notities.id) AS note_count
                FROM patiënten 
                LEFT JOIN notities ON patiënten.id = notities.patiënt_id
                WHERE is_deleted != true
                GROUP BY patiënten.id, voornaam;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            Console.WriteLine("geen patiënten gevonden");
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                SmallPatiënt patiënt = new SmallPatiënt()
                                {
                                    id = reader.GetInt32("id"),
                                    FirstName = reader.GetString("voornaam"),
                                    LastName = reader.GetString("achternaam"),
                                    PostalCode = reader.GetString("postcode"),
                                    City = reader.GetString("plaats"),
                                    NotesCount = reader.GetInt32("note_count")
                                };
                                patiënten.Add(patiënt);

                            }
                        }
                    }
                }
            }

            return patiënten;
        }

        public List<FullPatiënt> GetPatiënt(int id)
        {
            List<FullPatiënt> patiënten = new List<FullPatiënt>();
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = @"
SELECT patiënten.id, `voornaam`, `achternaam`, `adres`, `Huisnummer`, `postcode`, `plaats`, `Telefoonnummer`
FROM patiënten 
WHERE patiënten.id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32) { Value = id });
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            Console.WriteLine("geen patiënten gevonden");
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                FullPatiënt patiënt = new FullPatiënt()
                                {
                                    id = reader.GetInt32("id"),
                                    FirstName = reader.GetString("voornaam"),
                                    LastName = reader.GetString("achternaam"),
                                    Adres = reader.GetString("adres"),
                                    HouseNum = reader.GetString("Huisnummer"),
                                    PostalCode = reader.GetString("postcode"),
                                    City = reader.GetString("plaats"),
                                    PhoneNum = reader.GetString("Telefoonnummer")
                                };
                                patiënten.Add(patiënt);

                            }
                        }
                    }
                }
            }

            return patiënten;
        }

        public void UpdatePatiënt(FullPatiënt patiënt)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = "UPDATE `patiënten` SET `voornaam`= @vnaam,`achternaam`=@anaam,`adres`=@adres,`Huisnummer`=@huisnum,`postcode`=@postal,`plaats`=@city,`Telefoonnummer`=@tel WHERE id = @id";
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32) { Value = patiënt.id });
                    cmd.Parameters.Add(new MySqlParameter("@vnaam", MySqlDbType.VarChar) { Value = patiënt.FirstName });
                    cmd.Parameters.Add(new MySqlParameter("@anaam", MySqlDbType.VarChar) { Value = patiënt.LastName });
                    cmd.Parameters.Add(new MySqlParameter("@adres", MySqlDbType.VarChar) { Value = patiënt.Adres });
                    cmd.Parameters.Add(new MySqlParameter("@huisnum", MySqlDbType.VarChar) { Value = patiënt.HouseNum });
                    cmd.Parameters.Add(new MySqlParameter("@postal", MySqlDbType.VarChar) { Value = patiënt.PostalCode });
                    cmd.Parameters.Add(new MySqlParameter("@city", MySqlDbType.VarChar) { Value = patiënt.City });
                    cmd.Parameters.Add(new MySqlParameter("@tel", MySqlDbType.VarChar) { Value = patiënt.PhoneNum });

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddPatiënt(FullPatiënt patiënt)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = @"INSERT INTO `patiënten`( `voornaam`, `achternaam`, `adres`, `Huisnummer`, `postcode`, `plaats`, `Telefoonnummer`) 
VALUES (@vnaam,@anaam,@adres,@huisnum,@postal,@city,@tel)";
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32) { Value = patiënt.id });
                    cmd.Parameters.Add(new MySqlParameter("@vnaam", MySqlDbType.VarChar) { Value = patiënt.FirstName });
                    cmd.Parameters.Add(new MySqlParameter("@anaam", MySqlDbType.VarChar) { Value = patiënt.LastName });
                    cmd.Parameters.Add(new MySqlParameter("@adres", MySqlDbType.VarChar) { Value = patiënt.Adres });
                    cmd.Parameters.Add(new MySqlParameter("@huisnum", MySqlDbType.VarChar) { Value = patiënt.HouseNum });
                    cmd.Parameters.Add(new MySqlParameter("@postal", MySqlDbType.VarChar) { Value = patiënt.PostalCode });
                    cmd.Parameters.Add(new MySqlParameter("@city", MySqlDbType.VarChar) { Value = patiënt.City });
                    cmd.Parameters.Add(new MySqlParameter("@tel", MySqlDbType.VarChar) { Value = patiënt.PhoneNum });

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeletePatiënt(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = "UPDATE `patiënten` SET `is_deleted` = '1' WHERE `id` = @id;";
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32) { Value = id });
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public List<SmallPatiënt> SearchPatiënt(string ZoekQuery)
        {
            List<SmallPatiënt> patiënten = new List<SmallPatiënt>();
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = @"SELECT patiënten.id, `voornaam`, `achternaam`, `postcode`, `plaats`,  COUNT(notities.id) AS note_count 
                FROM `patiënten`
                LEFT JOIN notities ON patiënten.id = notities.patiënt_id
                WHERE is_deleted != true and voornaam like @zoek OR achternaam LIKE  @zoek
                GROUP BY patiënten.id, voornaam;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new MySqlParameter("@zoek", MySqlDbType.VarChar) { Value = $"%{ZoekQuery}%" });
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            Console.WriteLine("geen patiënten gevonden");
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                SmallPatiënt patiënt = new SmallPatiënt()
                                {
                                    id = reader.GetInt32("id"),
                                    FirstName = reader.GetString("voornaam"),
                                    LastName = reader.GetString("achternaam"),
                                    PostalCode = reader.GetString("postcode"),
                                    City = reader.GetString("plaats"),
                                    NotesCount = reader.GetInt32("note_count")
                                };
                                patiënten.Add(patiënt);

                            }
                        }
                    }
                }
            }
            return patiënten;
        }

        public List<note> GetNotes(int id)
        {
            List<note> notes = new List<note>();
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = @"
                SELECT `id`, `notitie_title`, `notitie`, `datum_update` 
                from notities
                WHERE `patiënt_id` = @id;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32) { Value = id });

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            Console.WriteLine("geen patiënten gevonden");
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                note Note = new note()
                                {
                                    id = reader.GetInt32("id"),
                                    title = reader.GetString("notitie_title"),
                                    text = reader.GetString("notitie"),
                                    updateDate = reader.GetDateTime("datum_update")
                                };
                                notes.Add(Note);

                            }
                        }
                    }
                }
            }

            return notes;
        }
        public void UpdatewNote(note Note)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = @"UPDATE `notities` SET 
`notitie_title`=@title,
`notitie`= @text,
`datum_update`= @time -- current_timestamp()
WHERE id = @id";
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32) { Value = Note.id });
                    cmd.Parameters.Add(new MySqlParameter("@title", MySqlDbType.VarChar) { Value = Note.title });
                    cmd.Parameters.Add(new MySqlParameter("@text", MySqlDbType.Text) { Value = Note.text });
                    cmd.Parameters.Add(new MySqlParameter("@time", MySqlDbType.DateTime) { Value = Note.updateDate });

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void AddNote(note Note, int id)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = @"INSERT INTO 
`notities`( `patiënt_id`, `notitie_title`, `notitie`, `datum_update`) 
VALUES (@id, @title, @text, @time)";
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32) { Value = id });
                    cmd.Parameters.Add(new MySqlParameter("@title", MySqlDbType.VarChar) { Value = Note.title });
                    cmd.Parameters.Add(new MySqlParameter("@text", MySqlDbType.Text) { Value = Note.text });
                    cmd.Parameters.Add(new MySqlParameter("@time", MySqlDbType.DateTime) { Value = Note.updateDate });

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
