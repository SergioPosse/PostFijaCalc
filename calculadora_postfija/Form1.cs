using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_postfija
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ACLARACION: solo se valida si hay menos de 3 caracteres en el string ya que no se puede operar
        //con un solo numero o sin operando, se necesitan 3 (dos numeros y un operando).
        //NO valido division por 0, resultados en decimales, cantidad de clics (se se pasan apretando calcular)
        //no valido el orden correcto de botones (primero apretar ordenar y luego calcular n veces).
        //      
        //===============================================================================================
        ///Primero transformo una cadena que va a ser mi operacion, a un array, asi lo recorro y guardo
        ///en una LISTA los numeros (esto es asi para separar numeros de mas de una cifra) y otra LISTA
        //los operandos, elegi listas para poder acdeder dinamicamente y manejar mejor los datos que me van
        //a ordenar la operacion primero. Despues ..con los operandos separados de los numeros,
        //calculo todo en una pila de longitud 3, la pila se llena cuando pushean un operando en ella,
        //en ese momento, se calcula la operacion con una funcion global y se guarda el resultado
        //en una variable, que luego de hacer pop hasta vaciar la pila, se guarda como primer 
        //elemento en la pila para el calculo siguiente.
        //
        //
        //variables globales
        public static class glo
        {
            public static Stack<string> pila_aux_3 = new Stack<string>();
            public static int cont=0;
            public static int cont2=0;
            public static List<int> lista_numeros = new List<int>();
            public static List<char> lista_operandos = new List<char>();
            public static int valor1 = 0;
            public static int valor2 = 0;
            public static int resul = 0;
            public static int aux = 0;
            public static string operando = "";
            public static Boolean flag = false;
        }
        //Funcion global operacion entre dos numeros
        public int mix(int number1, int number2,string x)
        {
            int resultado = 0;
            switch (x)
            {
                case "+":
                    resultado = number1 + number2;
                    break;
                case "-":
                    resultado = number1 - number2;
                    break;
                case "/":
                    resultado = number1 / number2;
                    break;
                case "*":
                    resultado = number1 * number2;
                    break;
                default:
                    break;
            }
            return resultado;
        }

        private void btn_ordenar_Click(object sender, EventArgs e)//boton ordenar
        {

            //le asigno a un string la operacion que voy a escribir en el textbox
            //para luego recorrer el string y tratarlo char por char con bucles
            string operacion = "";

            operacion = Convert.ToString(txt_operacion.Text);

            String s = operacion;

            //convierto el string en un arreglo de caracteres, asi puedo recorrerlos individualmene
            //en un bucle con la var local "i" del for

            var c = s.ToCharArray();

            int contador = 1;
            int contador2 = 1;
            string[] arreglo_numero_completo = new string[0];
            int[] arreglo_numeros = new int[0];
            char[] arreglo_operandos = new char[0];
            string final = null;

            if (c.Length < 2) //se necesitan 3 caracteres al menos para q se considere una operacion matematica
            {
                MessageBox.Show("Nada que ordenar u operacion muy corta");
            }
            else
            {
                //si hay una operacion escrita y que tiene 3 caracteres o mas entonces se procede al calculo
                //hago un for para recorrer el arreglo char
                for (int i = 0; i < c.Length; i++)
                {

                    //SI EL CHAR ES UN NUMERO ENTONCES EMPIEZO A ALMACENARLO EN UN ARREGLO
                    if ((c[i] != Convert.ToChar("+")) && (c[i] != Convert.ToChar("-") && (c[i] != Convert.ToChar("*")) && (c[i] != Convert.ToChar("/"))))
                    {
                        //resize solo lo uso para poder inicializar el arreglo con un length que va a depender
                        //del contador que me marca las posiciones del arreglo que voy armando caracter por caracter
                        //en el for
                        //el contador empieza en 1 porque significa que es un arreglo de 1 caracter nomas
                        //no confundir con la posicion que es [0] para ese array de 1 solo elemento.
                        Array.Resize(ref arreglo_numero_completo, contador);

                        //ahora si uso el contador que determina el tamaño del array pero le resto 1
                        //asi uso el contador como posicion tambien para insertar el char de la operacion
                        //que el condicional ya me dijo que no es un operador entonces es un numero
                        //y hasta que no encuentre un operador el for principal no entra en el otro if
                        //esto es por que el numero puede ser de 1 digito 2 o n digitos.
                        arreglo_numero_completo[contador - 1] = Convert.ToString(c[i]);

                        //dejo listo el contador por si encuentra en la proxima vuelta otro numero
                        //que lo vaya concatenando al arreglo_numero_completo
                        //que nos va a determinar nuestro primer numero de la operacion

                        contador = contador + 1;

                        //tambien tengo que tener en cuenta si el numero que se esta construyendo es el ultimo
                        //de la operacion para eso controlo la cima del arreglo char del principio que recorre el 
                        //for principal
                        if (i == c.Length - 1)
                        {
                            //si es el ultimo numero entonces tengo que agregar lo que construi con
                            //arreglo_numero_completo al arreglo final que es arreglo_numeros, el cual seria 
                            //nuestra primer pila para los numeros

                            //le doy el tamaño al arreglo_numero con el contador2 que tambien empieza en 1
                            //pero recordar que estamos en un if que es el ultimo numero asi que seguro ya no es 1
                            //sino que se fue acumulando en el if de mas abajo donde guardo los operandos

                            Array.Resize(ref arreglo_numeros, contador2);

                            //ahora hago un for para transformar el array a un string comun sino no puedo
                            //asignar el array al arreglo_numeros sin recorrer uno por uno me da error c sharp
                            for (int j = 0; j < arreglo_numero_completo.Length; j++)
                            {
                                final += Convert.ToString(arreglo_numero_completo[j]);
                            }
                            //finalmente hago el push a la pila de arreglo_numeros
                            arreglo_numeros[(contador2) - 1] = Convert.ToInt32(final);

                        }

                    }
                    else
                        //cuando el caracter es un operando entonces tengo que construir ahora 
                        //el arreglo de los operandos arreglo_operandos
                        if ((c[i] == Convert.ToChar("+")) | (c[i] == Convert.ToChar("-")) | (c[i] == Convert.ToChar("/")) | (c[i] == Convert.ToChar("*")))
                        {

                            //MessageBox.Show("entro al else");
                            //como se encontro un operando significa que se acabo un numero y ahora
                            //se añade un numero al arreglo de numeros y el operando al arreglo_operandos
                            //completo al array de numeros y un operando al array de operandos
                            //asi que aumenta el maximo y debo hacer un resize del array que inicie
                            //en 0 para que no me diera error c sharp
                            Array.Resize(ref arreglo_operandos, contador2);
                            Array.Resize(ref arreglo_numeros, contador2);

                            //agrego el operando encontrado al arreglo
                            arreglo_operandos[contador2 - 1] = c[i];


                            //si se guardo un numero completo que se construyo con finalScore ahora
                            //lo reinicializo para usarlo con el proximo arreglo_numero_completo
                            final = null;

                            for (int j = 0; j < arreglo_numero_completo.Length; j++)
                            {
                                //MessageBox.Show(arreglo_numero_completo[j]);
                                final += Convert.ToString(arreglo_numero_completo[j]);
                                //MessageBox.Show(finalScore);

                            }
                            //MessageBox.Show(Convert.ToString(contador2));
                            //se agrega el numero completo a la pila de numeros cuando se construyo el final
                            arreglo_numeros[(contador2) - 1] = Convert.ToInt32(final);

                            //COMO YA TENGO UN IF PARA COMPROBAR SI ES EL ULTIMO NUMERO DE LA OPERACION ESTE
                            //NO LO ES ENTONCES NECESITO VACIAR EL ARREGLO PARA IR ARMANDO EL PROXIMO
                            //YA QUE ESTAMOS ACA PORQUE EL CARACTER DE LA VUELTA DEL FOR ES UN OPERANDO
                            //ENTONCES EL PROXIMO ES OBVIO UN NUMERO

                            Array.Clear(arreglo_numero_completo, 0, arreglo_numero_completo.Length);

                            //el contador 2 nunca lo reinicio porque es el que me define los dos
                            //arreglos finales osea las 2 pilas con las que quiero trabajar realmente
                            contador2 = contador2 + 1;

                            //lo demas reinicializar..
                            contador = 1;
                            final = null;
                        }
                } //fin del for q recorre C
            }//fin del else que pertenece al if de si esta vacio el textbox

            glo.lista_numeros = new List<int>(arreglo_numeros);
            glo.lista_operandos = new List<char>(arreglo_operandos);
            //labels randoms para ver como va el proceso

            lbl_ordenada.Text = Convert.ToString(arreglo_numeros[0]);
            lbl_resultado2.Text = Convert.ToString(arreglo_numeros[1]);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_operacion.Text = "";
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            //convierto mis arreglos a pilas para poder hacer uso del "push" o "pop"
            lbl_resultado.Text = Convert.ToString(glo.cont);
            //MessageBox.Show(Convert.ToString(pila_numeros[0]));
            //MessageBox.Show(Convert.ToString(pila_numeros[1]));
            if ((glo.lista_numeros.Count == 0)&&(glo.lista_operandos.Count == 0)&&(glo.cont==0))
            {
                MessageBox.Show("YA NO HAY ELEMENTOS QUE PROCESAR");
            }
            else
            {
                if (glo.cont == 0)//asigno el valor 1
                {
                    if (glo.flag == false)
                    {
                        glo.pila_aux_3.Push(Convert.ToString(glo.lista_numeros[0]));
                        txt_0.Text = glo.pila_aux_3.Peek();
                        glo.valor1 = Convert.ToInt32(txt_0.Text);
                        glo.lista_numeros.RemoveAt(0);
                    }
                    else {
                        glo.pila_aux_3.Push(Convert.ToString(glo.resul));
                        txt_0.Text = Convert.ToString(glo.resul);
                        glo.valor1 = glo.resul; //como es el resultado nomas q se asigna
                        //no saco el elemento de la lista numeros asi lo uso despues en el valor2
                    }
                }
                else if (glo.cont == 1)// asigno el valor 2
                {
                    if (glo.flag == false)
                    {
                        glo.pila_aux_3.Push(Convert.ToString(glo.lista_numeros[0]));
                        txt_1.Text = glo.pila_aux_3.Peek();
                        glo.valor2 = Convert.ToInt32(txt_1.Text);
                        glo.lista_numeros.RemoveAt(0);
                    }
                    else
                    {
                        glo.pila_aux_3.Push(Convert.ToString(glo.lista_numeros[0]));
                        txt_1.Text = glo.pila_aux_3.Peek();
                        glo.valor2 = Convert.ToInt32(txt_1.Text);
                        glo.lista_numeros.RemoveAt(0);
                    }
                }
                else if (glo.cont == 2)
                {
                    glo.pila_aux_3.Push(Convert.ToString(glo.lista_operandos[0]));
                    txt_2.Text = glo.pila_aux_3.Peek();
                    glo.operando = txt_2.Text;
                    glo.lista_operandos.RemoveAt(0);
                }
                else if (glo.cont == 3) // significa que hay que calcular y reiniciar todo
                    //y evaluar si todavia quedan mas numeros para calcular al resultado obtenido
                {
                    glo.resul = mix(glo.valor1, glo.valor2, glo.operando);
                    lbl_resultado_final.Text = Convert.ToString(glo.resul);
                    lbl_resultado_final.Visible = true;

                    glo.cont = -1;
                    glo.valor1 = 0;
                    //glo.valor2 = 0;
                    glo.operando = "";
                    glo.pila_aux_3.Pop();
                    glo.pila_aux_3.Pop();
                    glo.pila_aux_3.Pop();
                    txt_0.Text = "";
                    txt_1.Text = "";
                    txt_2.Text = "";

                    if (glo.lista_numeros.Count > 0) 
                    {//si despues de operar con 2 numeros, todavia quedan en la lista numeros.. sigue
                        //ahora los if del contador entran al flag donde el valor 1 es el resultado siempre
                        glo.flag = true;
                    }
                }
 
             }
            glo.cont = glo.cont + 1;
           }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }//fin del recorrido del boton
        
        }// fin de la partial class
    }
    