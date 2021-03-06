﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Business
{
    public class BusinessLayer
    {

        public BusinessLayer() : this(new Entities.Entities())
        {
        }

        public BusinessLayer(Entities.Entities context)
        {
            Data = context;
            GestionUtilisateurs = new Operations.GestionUtilisateurs(this);
            GestionClients = new Operations.GestionClients(this);
            GestionHotel = new Operations.GestionHotel(this);
            GestionReservations = new Operations.GestionReservations(this);
        }

        public Entities.Entities Data { get; private set; }

        public Operations.GestionUtilisateurs GestionUtilisateurs { get; private set; }

        public Operations.GestionClients GestionClients { get; private set; }

        public Operations.GestionHotel GestionHotel { get; private set; }

        public Operations.GestionReservations GestionReservations { get; private set; }
    }
}
