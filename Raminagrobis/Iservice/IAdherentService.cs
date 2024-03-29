﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raminagrobis
{
    public interface IAdherentService
    {
        public List<Adherent> GetAll();
        public Adherent GetByID(int ID);
        public Adherent Insert(Adherent a);
        public Adherent Update(Adherent a);
        public void Delete(Adherent a);
    }
}
