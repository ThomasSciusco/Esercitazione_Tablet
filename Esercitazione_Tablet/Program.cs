using System;
using System.Threading;

namespace Eserciazione_tablet
{

    public class tablet
    {
        public string marca;
        public float dimensioni;
        public float batteria;
        public float velocità;

        public tablet(string marca,float dimensioni,float batteria,float velocità) 
        {
            this.marca = marca;
            this.dimensioni = dimensioni;
            this.batteria = batteria;
            this.velocità = velocità;
        }

    }
}