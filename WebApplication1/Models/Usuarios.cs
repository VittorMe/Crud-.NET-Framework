﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Usuarios
    {
        private readonly static string _conn = @"Data Source=DESKTOP-U1KMBNO;Initial Catalog=AgenciaAuto;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public int Id { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public bool Login()
        {
            var result = false;
            var sql = "SELECT Id, Nome, Senha FROM Usuarios WHERE Email = '" + this.Email + "'";

            try
            {
                using (var cn = new SqlConnection(_conn))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    if(this.Senha ==dr["senha"].ToString())
                                    this.Id = Convert.ToInt32(dr["id"]);
                                    this.Nome = dr["nome"].ToString();
                                    result = true;
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha: " + ex.Message);
            }
            return result;
        }
    }
}