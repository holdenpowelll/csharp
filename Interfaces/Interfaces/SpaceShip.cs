﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SpaceShip : IJoystick
    {
        int m_sequence;


        public bool Up()
        {
            if (m_sequence == 0 || m_sequence == 1)
            { m_sequence++; }
            else
                m_sequence = 0;
            return false;
        }

        public bool Down()
        {
            throw new NotImplementedException();
        }

        public bool Left()
        {
            throw new NotImplementedException();
        }

        public bool Right()
        {
            throw new NotImplementedException();
        }

        public bool A()
        {
            throw new NotImplementedException();
        }

        public bool B()
        {
            throw new NotImplementedException();
        }

        public bool Select()
        {
            throw new NotImplementedException();
        }

        public bool Start()
        {
            throw new NotImplementedException();
        }
    }
}
