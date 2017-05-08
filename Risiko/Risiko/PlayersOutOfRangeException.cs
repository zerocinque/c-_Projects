using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risiko {
    class PlayersOutOfRangeException : Exception{
        public PlayersOutOfRangeException() {
        }

        public PlayersOutOfRangeException(string message) : base(message){

        }

        public PlayersOutOfRangeException(string message, Exception inner) : base(message, inner){

        }
    }
}
