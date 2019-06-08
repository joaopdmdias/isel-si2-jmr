﻿/*
 * Este código foi desenvolvido para exemplificação e consolidação
 * de coceitos da unidade curricular Arquitectura de Sistemas de Informação do
 * Mestredo em Engenharia Informática e de Computadores do Instituto Superior de Engenharia
 * de Lisboa (Institupo Politécnico de Lisboa)
 * Não é completo, nem é destinado a ser usado como peça de produtos informáticos fora 
 * do âmbito pedagógico.
 * 
 * -------------------------------------
 * Autor: Walter Vieira
 * -------------------------------------
 * Data de criaçao: 2012/11/14
 * -------------------------------------
 * História de alterações:
 * 
 * 2012/11/19 - Walter Vieira. Introduzidos estes comentários.
 * 
 * 
*/

/*
 * Este código foi desenvolvido para exemplificação e consolidação
 * de conceitos da unidade curricular ASistemas de Informação II da
 * Licenciatura em Engenharia Informática e de Computadores do Instituto Superior de Engenharia
 * de Lisboa (Institupo Politécnico de Lisboa)
 * Não é completo, nem é destinado a ser usado como peça de produtos informáticos fora 
 * do âmbito pedagógico.
 * 
 * -------------------------------------
 * Autor: Walter Vieira
 * -------------------------------------
 * Data de criaçao: 2012/12/17
 * -------------------------------------
 * História de alterações:
 * 
 
 * 
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Configuration;
using System.Transactions;

using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;


using SI2_CO.Entities;
using SI2_CO.Mapper_Interfaces;



namespace SI2_CO.Mapper
{
    class MapperFornecedor : IMapperFornecedor
    {

        private string cs;

        public MapperFornecedor()
        {
            cs = ConfigurationManager.ConnectionStrings["SI2"].ConnectionString;
        }

        public void Create(Fornecedor forn)
        {
            using (var ts = new TransactionScope(TransactionScopeOption.Required))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO FORNECEDOR(Nif,Nome) VALUES(@Nif,@Nome)";
                SqlParameter NifParam = new SqlParameter();
                SqlParameter NomeParam = new SqlParameter();

                cmd.Parameters.Add(NifParam);
                cmd.Parameters.Add(NomeParam);

                NifParam.ParameterName = "@Nif";
                NifParam.SqlDbType = SqlDbType.Int;
                NomeParam.ParameterName = "@Nome";
                NomeParam.SqlDbType = SqlDbType.VarChar;
                NomeParam.Size = 40;

                NifParam.Value = forn.Nif;
                NomeParam.Value = forn.Nome;

                using (var cn = new SqlConnection(cs))
                {

                    cmd.Connection = cn;
                    cn.Open();

                    cmd.ExecuteNonQuery();

                }
                ts.Complete();
            }
        }

        public Fornecedor Read(int foid)
        {
            using (var ts = new TransactionScope(TransactionScopeOption.Required))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM FORNECEDOR WHERE Foid = @Foid";

                SqlParameter FoidParam = new SqlParameter();
                cmd.Parameters.Add(FoidParam);
                FoidParam.ParameterName = "@Foid";
                FoidParam.SqlDbType = SqlDbType.Int;
                FoidParam.Value = foid;

                using (var cn = new SqlConnection(cs))
                {

                    cmd.Connection = cn;
                    cn.Open();

                    cmd.ExecuteNonQuery();

                }
                ts.Complete();
            }
        }

        public void Update(Fornecedor forn)
        {
            using (var ts = new TransactionScope(TransactionScopeOption.Required))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "UPDATE FORNECEDOR SET Nif = @Nif, Nome = @Nome WHERE Foid = @Foid";
                SqlParameter NifParam = new SqlParameter();
                SqlParameter NomeParam = new SqlParameter();
                SqlParameter FoidParam = new SqlParameter();


                cmd.Parameters.Add(NifParam);
                cmd.Parameters.Add(NomeParam);
                cmd.Parameters.Add(FoidParam);

                NifParam.ParameterName = "@Nif";
                NifParam.SqlDbType = SqlDbType.Int;
                NomeParam.ParameterName = "@Nome";
                NomeParam.SqlDbType = SqlDbType.VarChar;
                NomeParam.Size = 40;
                FoidParam.ParameterName = "@Foid";
                FoidParam.SqlDbType = SqlDbType.Int;

                NifParam.Value = forn.Nif;
                NomeParam.Value = forn.Nome;
                FoidParam.Value = forn.Foid;

                using (var cn = new SqlConnection(cs))
                {

                    cmd.Connection = cn;
                    cn.Open();

                    cmd.ExecuteNonQuery();

                }
                ts.Complete();
            }
        }
        public void Delete(Fornecedor forn)
        {
            using (var ts = new TransactionScope(TransactionScopeOption.Required))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "DELETE FROM FORNECEDOR WHERE Foid = @Foid";
                SqlParameter NifParam = new SqlParameter();
                SqlParameter NomeParam = new SqlParameter();
                SqlParameter FoidParam = new SqlParameter();


                cmd.Parameters.Add(NifParam);
                cmd.Parameters.Add(NomeParam);
                cmd.Parameters.Add(FoidParam);

                NifParam.ParameterName = "@Nif";
                NifParam.SqlDbType = SqlDbType.Int;
                NomeParam.ParameterName = "@Nome";
                NomeParam.SqlDbType = SqlDbType.VarChar;
                NomeParam.Size = 40;
                FoidParam.ParameterName = "@Foid";
                FoidParam.SqlDbType = SqlDbType.Int;

                NifParam.Value = forn.Nif;
                NomeParam.Value = forn.Nome;
                FoidParam.Value = forn.Foid;

                using (var cn = new SqlConnection(cs))
                {

                    cmd.Connection = cn;
                    cn.Open();

                    cmd.ExecuteNonQuery();

                }
                ts.Complete();
            }
        }

    }
}