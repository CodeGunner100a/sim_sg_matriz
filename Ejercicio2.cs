
  //PREGUNTA 2 =========== simulacro

        public void Ejercicio2()
        {
            int p, d;
            for (p = 1; p <= f - 1; p++)
            {
                for (d = p + 1; d <= f; d++)
                {
                    if (ContadorDiferentes(p) < ContadorDiferentes(d))
                    {
                        Intercambiarfilas(p, d);
                    }
                }
            }
            for (int f1 = 1; f1 <= f; f1++)
            {
                x[f1, c + 1] = ContadorDiferentes(f1);
            }
            c++;
        }

        public int ContadorDiferentes(int f1)
        {
            int cont = 0;
            int c1, c2;
            bool yaContado;
            for (c1 = 1; c1 <= c; c1++)
            {
                yaContado = false;
                for (c2 = 1; c2 < c1; c2++)
                {
                    if (x[f1, c2] == x[f1, c1])
                    {
                        yaContado = true;
                    }
                }
                if (!yaContado)
                {
                    cont++;
                }
            }
            return cont;
        }
        public void Intercambiarfilas(int f1, int f2)
        {
            int c1;
            for (c1 = 1; c1 <= c; c1++)
            {
                Intercambiar(f1, c1, f2, c1);
            }
        }
        public void Intercambiar(int f1, int c1, int f2, int c2)
        {
            int aux = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }



//llamada  -----------------------------------------

x1.Ejercicio2();

