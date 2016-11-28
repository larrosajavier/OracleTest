﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace OracleTest
{
	class Program
	{
		static void Main(string[] args)
		{
			try {
				if (args.Length < 3)
					Console.WriteLine("Ingrese datos:  OracleTest.exe <server> <user> <password>");
				else{
					string connectionString = string.Format("Data Source={0};User ID={1};Password={2}", args[0], args[1], args[2]);
					Console.WriteLine("Conectando con connectionstring:" + connectionString);
					OracleConnection conn = new OracleConnection(connectionString);
					conn.Open();
					conn.Close();
					Console.WriteLine("OK");
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine("ERROR");
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.StackTrace);
			}

		}
		
	}
}
