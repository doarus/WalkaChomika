﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkaChomika.Models
{
    /// <summary>
    /// Dinozaur, klasa dziedzicząca po Zwierzę
    /// </summary>
    class Dinozaur : Zwierzę
    {
        /// <summary>
        /// Konstruktor, nadaje bazowe, bardzo duże,
        /// wartości HP i obrazeń
        /// </summary>
        /// <param name="imię">Imię stworzenia</param>
        public Dinozaur(string imię) : base(imię)
        {
            this.HP = 100000;
            this.Damage = 150;
        }
    }
}
