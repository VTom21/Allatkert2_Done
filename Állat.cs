using System;
using System.Collections.Generic;
using System.Text;

namespace Allatkert2
{
    internal class Állat
    {
        public int AllatId { get; set; }
        public string? Nev { get; set; }
        public string Faj { get; set; }
        public float Eletkor { get; set; }
        public Részleg Reszleg { get; set; }
        public Gondozó Gondozo { get; set; }

        public object[] Get_Row() => [Faj, Nev, Eletkor, Reszleg.Nev, Gondozo.Nev];

        public Állat(string sor)
        {
            var v = sor.Split(';');
            AllatId = int.Parse(v[0]);
            Nev = v[1] == "NULL" ? null : v[1];
            Faj = v[2];
            Eletkor = float.Parse(v[3].Replace('.', ','));

            Reszleg = new()
            {
                Id = int.Parse(v[4]),
                Nev = v[5],
                Meret = int.Parse(v[6])
            };

            Gondozo = new() { 

                Id = int.Parse(v[7]),
                Nev = v[8],
                Szakterulet = v[9]

            };
        }
    }
}
