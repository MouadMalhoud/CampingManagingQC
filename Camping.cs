using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouadMalhoudLaboratoire2
{
    class Camping
    {
        private int _numCamping;
        private String _nomCamping;
        private String _cheminImage;

        public Camping() {}
        public Camping(int pNumCamping, string pNomCamping, string pCheminImage)
        {
            _numCamping = pNumCamping;
            _nomCamping = pNomCamping;
            _cheminImage = pCheminImage;
        }
        public int numCamping { get; set; }
        public string nomCamping { get; set; }
        public string cheminImage { get; set; }

    }
   
}
