﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_become_milioner
{
    public interface ISerializer
    {
        void Save(ICollection<Question> collection);
        ICollection<Question> Load();
    }
}
