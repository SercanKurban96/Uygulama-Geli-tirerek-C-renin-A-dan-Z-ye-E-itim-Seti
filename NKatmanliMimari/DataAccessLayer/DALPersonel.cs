﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut1 = new SqlCommand("Select * From TBLBILGI",Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Sehir = dr["SEHIR"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Maas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLBILGI (AD,SOYAD,SEHIR,GOREV,MAAS) VALUES (@p1,@p2,@p3,@p4,@p5)",Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p.Ad);
            komut2.Parameters.AddWithValue("@p2", p.Soyad);
            komut2.Parameters.AddWithValue("@p3", p.Sehir);
            komut2.Parameters.AddWithValue("@p4", p.Gorev);
            komut2.Parameters.AddWithValue("@p5", p.Maas);
            return komut2.ExecuteNonQuery();
        }

        public static bool PersonelSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("delete from TBLBILGI where ID = @p1",Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1",p);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static bool PersonelGuncelle(EntityPersonel ent)
        {
            SqlCommand komut4 = new SqlCommand("update TBLBILGI set AD=@p1,SOYAD=@p2,SEHIR=@p3,GOREV=@p4,MAAS=@p5 where ID=@p6",Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1",ent.Ad);
            komut4.Parameters.AddWithValue("@p2",ent.Soyad);
            komut4.Parameters.AddWithValue("@p3",ent.Sehir);
            komut4.Parameters.AddWithValue("@p4",ent.Gorev);
            komut4.Parameters.AddWithValue("@p5",ent.Maas);
            komut4.Parameters.AddWithValue("@p6",ent.Id);
            return komut4.ExecuteNonQuery() > 0;
        }
    }
}
