using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Paint
{
    public class anBrush
    {
        public Bitmap myBrush;
        // стандартная (квадратная) кисть, с указанием масштаба 
        // и флагом закраски углов 
        public anBrush(int Value, bool Special)
        {
            if (!Special)
            {
                myBrush = new Bitmap(Value, Value);
                for (int ax = 0; ax < Value; ax++)
                    for (int bx = 0; bx < Value; bx++)
                        myBrush.SetPixel(0, 0, Color.Black);
                // не является стеркой 
                IsErase = false ;
                
            }
            else
            {
                // здесь мы будем размещать предустановленные кисти 
                // созданная нами ранее кисть в виде перекрестия двух линий будет кистью по умолчанию 
                // на тот случай, если задан не описанный номер кисти 
                switch (Value)
                {
                    default:
                        {
                            myBrush = new Bitmap(5, 5);
                            for (int ax = 0; ax < 5; ax++)
                                for (int bx = 0; bx < 5; bx++)
                                    myBrush.SetPixel(ax, bx, Color.Red);
                            myBrush.SetPixel(0, 2, Color.Black);
                            myBrush.SetPixel(1, 2, Color.Black);
                            myBrush.SetPixel(2, 0, Color.Black);
                            myBrush.SetPixel(2, 1, Color.Black);
                            myBrush.SetPixel(2, 2, Color.Black);
                            myBrush.SetPixel(2, 3, Color.Black);
                            myBrush.SetPixel(2, 4, Color.Black);
                            myBrush.SetPixel(3, 2, Color.Black);
                            myBrush.SetPixel(4, 2, Color.Black);
                            // не является стеркой 
                            IsErase = false;
                            break;
                        }
                    case 1:
                        // ластик
                        {
                            // создается так же, как и обычная кисть, 
                            // но имеет флаг IsErase равный true 
                            myBrush = new Bitmap(5, 5);
                            for ( int ax = 0; ax < Value; ax++)
                                for ( int bx = 0; bx < Value; bx++)
                                    myBrush.SetPixel(0, 0, Color.Black); // является ластиком 
                            IsErase = true ;
                            break ;
                        }
                        
                }
            }
        }
        // второй конструктор будет позволять загружать кисть из стороннего файла 
        public anBrush(string FromFile)
        {
            string path = Directory.GetCurrentDirectory(); path += "\\" + FromFile; myBrush = new Bitmap(path);
        }
        // флаг, сигнализирующий о том, что установленная кисть является ластиком 
        private bool IsErase = false;
        // функция, которая будет использоваться для получения информации 
        // о том, является ли данная кисть стеркой. 
        public bool IsBrushErase()
        {
            return IsErase;
        }
        
    } 
        
}
