﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_apartments_app.db.dao
{
    public abstract class SuperDao<T>
    {
        public abstract T getSingle(string id);
        public abstract T[] getAll();
    }
}