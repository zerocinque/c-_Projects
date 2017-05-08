using System;

namespace Risiko {
    public static class Dado
    {
         public static int tiraDado() {
            Random rand = new Random();
            return rand.Next(1,6);
        }
    }
}
