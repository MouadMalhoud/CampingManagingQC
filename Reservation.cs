using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouadMalhoudLaboratoire2
{
    class Reservation
    {
        private int _numReservation;
        private int _numCamping;
        private String _nomClient;
        private String _pays;
        private String _courriel;
        private DateTime _debutRes;
        private DateTime _finRes;
        private String _serviceChoisi;
        private double _coutService;
        private int _nbAdulte;
        private int _nbEnfantAge;
        private int _nbEnfantJeune;
        private double _coutTotal;

        public Reservation(int pNumRes, int pNumCamp, String pNomClient, String pPays, String pCourriel, DateTime pDebutRes, DateTime pFinRes,
            String pServiceChoisi, double pCoutService, int pNbAdulte, int pNbEnfantAge, int pNbEnfantJeune, double pCoutTotal)
        {
            _numReservation = pNumRes;
            _numCamping = pNumCamp;
            _nomClient = pNomClient;
            _pays = pPays;
            _courriel = pCourriel;
            _debutRes = pDebutRes;
            _finRes = pFinRes;
            _serviceChoisi = pServiceChoisi;
            _coutService = pCoutService;
            _nbAdulte = pNbAdulte;
            _nbEnfantAge = pNbEnfantAge;
            _nbEnfantJeune = pNbEnfantJeune;
            _coutTotal = pCoutTotal;
        }
        public int NumReservation { get; set; }
        public int NumCamping { get; set; }
        public String NomClient { get; set; }
        public String Pays { get; set; }
        public String Courriel { get; set; }
        public DateTime DebutRes { get; set; }
        public DateTime FinRes { get; set; }
        public String ServiceChoisi { get; set; }
        public double CoutService { get; set; }
        public int NbAdulte { get; set; }
        public int NbEnfantAge { get; set; }
        public int NbEnfantJeune { get; set; }
        public double CoutTotal { get; set; }
    }
}
