﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutyak
{
    class Kutyafajta
    {
        private int id;
        private string nev;
        private string eredetiNev;

        public int ID { get { return id; } }
        public string NEV { get { return nev; } }
        public string EREDETINEV { get { return eredetiNev; } }

        public Kutyafajta(int id, string nev, string eredetiNev)
        {
            this.id = id;
            this.nev = nev;
            this.eredetiNev = eredetiNev;
        }
    }
}
