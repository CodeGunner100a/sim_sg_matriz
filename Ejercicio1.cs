
   //PREGUNTA 1 =========== simulacro

        public void Ejercicio1(int fi, int ff, int ci, int cf,
                                         ref int ele, ref int frec)
        {
            int f1, c1, v, fv;

            frec = -1; // máximo encontrado
            ele = -1;

            for (f1 = fi; f1 <= ff; f1++)
            {
                for (c1 = ci; c1 <= cf; c1++)
                {
                    v = x[f1, c1];
                    fv = FrecRango(v, fi, ff, ci, cf);


                    if (fv > frec || (fv == frec && v > ele))
                    {
                        frec = fv;
                        ele = v;
                    }
                }
            }
        }


        private int FrecRango(int v, int fi, int ff, int ci, int cf)
        {
            int k = 0;

            for (int f1 = fi; f1 <= ff; f1++)
                for (int c1 = ci; c1 <= cf; c1++)
                    if (x[f1, c1] == v)
                        k++;

            return k;
        }

//llamada  -----------------------------------------

 int fi = int.Parse(textBox1.Text);
            int ff = int.Parse(textBox2.Text);
            int ci = int.Parse(textBox3.Text);
            int cf = int.Parse(textBox4.Text);

            int ele = 0;   // variables locales que se llenarán por ref
            int frec = 0;

            x1.Ejercicio1(fi, ff, ci, cf, ref ele, ref frec);

            textBox6.Text = "ele = " + ele + "   frec = " + frec;











