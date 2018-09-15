using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace MS_Paint
{
    class anLayer
    {
        // размеры экранной области 
        public int Width, Heigth;
        // массив, представляющий область рисунка (координаты пикселя и его цвет), 
        private int[,,] DrawPlace;
        // который будет хранить растровые данные для данного слоя 
        public int[, ,] GetDrawingPlace() { return DrawPlace; }
        // флаг видимости слоя: true - видимый, false - невидимый 
        private bool isVisible;
        // текущий установленный цвет 
        private Color ActiveColor;

        public int ListNom { get; private set; }

        // конструктор класса, в качестве входных параметров 
        // мы получаем размеры изображения, чтобы создать в памяти массив, 
        // который будет хранить растровые данные для данного слоя 


        public anLayer(int s_W, int s_H)
        {
            // запоминаем значения размеров рисунка 
            Width = s_W;
            Heigth = s_H;
            // создаем в памяти массив, соответствующий размерам рисунка 
            // каждая точка на плоскости массива будет иметь 3 составляющие цвета 
            // + 4 ячейка - флаг, о том что данный пиксель пуст (или полностью прозрачен) 
            DrawPlace = new int[Width, Heigth, 4];
            // проходим по всей плоскости и устанавливаем всем точкам флаг, 
            // сигнализирующий, что они прозрачны 
            for (int ax = 0; ax < Width; ax++)
            {
                for (int bx = 0; bx < Heigth; bx++)
                {
                    // флаг прозрачности точки в координатах ax,bx. 
                    DrawPlace[ax, bx, 3] = 1;
                }
            }
            // устанавливаем флаг видимости слоя (по умолчанию создаваемый слой всегда видимый) 
            isVisible = true;
            // текущим активным цветом устанавливаем черный 
            // в следующей главе мы реализуем функции установки цветов из оболочки. 
            ActiveColor = Color.Black;
        }
        // функция установки режима видимости слоя 
        public void SetVisibility(bool visiblityState)
        {
            isVisible = visiblityState;
        }
        // функция получения текущего состояния видимости слоя 
        public bool GetVisibility()
        {
            return isVisible;
        }
        // функция рисования 
        // получает в качестве параметров кисть для рисования и координаты, 
        // где сейчас необходимо перерисовать пиксели заданной кистью 
        public void Draw(anBrush BR, int x, int y)
        {
        //    // определяем позиция старта рисования 
            int real_pos_draw_start_x = x - BR.myBrush.Width / 2;
            int real_pos_draw_start_y = y - BR.myBrush.Height / 2;
        //    // корректируем ее для не выхода за границы массива 
        //    // проверка на отрицательные значения (граница "справа") 
            if (real_pos_draw_start_x < 0)
                real_pos_draw_start_x = 0;
            if (real_pos_draw_start_y < 0)
                real_pos_draw_start_y = 0;
        //    // проверки на выход за границу "справа" 
            int boundary_x = real_pos_draw_start_x + BR.myBrush.Width;
            int boundary_y = real_pos_draw_start_y + BR.myBrush.Height;
            if (boundary_x > Width)
                boundary_x = Width;
            if (boundary_y > Heigth)
                boundary_y = Heigth;
        //    // счетчик пройденных строк и столбцов массива, представляющий собой маску кисти 
            int count_x = 0, count_y = 0;
        //    // цикл по области с учетом смещения кисти и коррекции для невыхода за границы массива 
        //    for (int ax = real_pos_draw_start_x; ax < boundary_x; ax++, count_x++)
        //    {
        //        count_y = 0;
        //        for (int bx = real_pos_draw_start_y; bx < boundary_y; bx++, count_y++)
        //        {
        //            // получаем текущий цвет пикселя маски 
        //            Color ret = BR.myBrush.GetPixel(count_x, count_y);
        //            // цвет не красный 
        //            if (!(ret.R == 255 && ret.G == 0 && ret.B == 0))
        //            {
        //                // заполняем данный пиксель соответствующим из маски, используя активный цвет 
        //                DrawPlace[ax, bx, 0] = ActiveColor.R;
        //                DrawPlace[ax, bx, 1] = ActiveColor.G;
        //                DrawPlace[ax, bx, 2] = ActiveColor.B;
        //                DrawPlace[ax, bx, 3] = 0;
        //            }
        //        }
        //    }
        // цикл по области с учетом смещения кисти и коррекции для невыхода за границы массива 
        for ( int ax = real_pos_draw_start_x; ax < boundary_x; ax++, count_x++)
            {
                count_y = 0;
                for ( int bx = real_pos_draw_start_y; bx < boundary_y; bx++, count_y++)
                {
                    // проверяем, не является ли данная кисть стеркой 
                    if (BR.IsBrushErase())
                    { // данная кисть - стерка. 
                      // помечаем данный пиксель как не закрашенный 
                      // получаем текущий цвет пикселя маски 
                        Color ret = BR.myBrush.GetPixel(count_x, count_y);
                        // цвет не красный 
                        if (!(ret.R == 255 && ret.G == 0 && ret.B == 0))
                        {
                            // заполняем данный пиксель соответствующим из маски, используя активный цвет 
                            DrawPlace[ax, bx, 3] = 1;
                        }
                    }
                    else
                    {
                        // получаем текущий цвет пикселя маски 
                        Color ret = BR.myBrush.GetPixel(count_x, count_y);
                        // цвет не красный 
                        if (!(ret.R == 255 && ret.G == 0 && ret.B == 0))
                        {
                            // заполняем данный пиксель соответствующим из маски, используя активный цвет 
                            DrawPlace[ax, bx, 0] = ActiveColor.R;
                            DrawPlace[ax, bx, 1] = ActiveColor.G;
                            DrawPlace[ax, bx, 2] = ActiveColor.B;
                            DrawPlace[ax, bx, 3] = 0;
                        }
                    }
                }
            }

        }
        // функция визуализации слоя 
        public void RenderImage(bool FromList)
        {
            if (FromList)
            // указана визуализация из дисплейного списка, следовательно данный слой не активен 
            {
                // вызываем дисплейный список 
                Gl.glCallList(ListNom);
            }
            else
            // данный слой активен, и визуализацию необходимо делать на ходу 
            {
                // счетчик номеров элементов, которые должны участвовать в визуализации 
                int count = 0;
                // проходим по всем точкам рисунка 
                for ( int ax = 0; ax < Width; ax++)
                {
                    for ( int bx = 0; bx < Heigth; bx++)
                    {
                        // если точка в координатах ax,bx не помечена флагом "прозрачная" 
                        if (DrawPlace[ax, bx, 3] != 1)
                        {
                            // не самый красивый способ, но так мы подсчитаем количество действительно значимых точек слоя,
                            // которые должны быть визуализированы 
                            count++;
                        }
                    }
                }
                // данный массив будет заполнен, а затем передан для быстрой отрисовки геометрии (точек в нашем случае) 
                // колч. точек * 2 (для хранения координат x и y каждой точки, которая будет отрисована 
                int [] arr_date_vertex = new int [count * 2];
                // данный массив будет содержать значения цветов для всех отрисовываемых точек 
                // колч. точек * 3 (для хранения координат R G B значений цветов каждой точки, которая будет отрисована) 
                float [] arr_date_colors = new float [count * 3];
                // счетчик элементов для создания массивов, которые будут переданы в реализацию OpenGL c 
                // помощью функции glDrawArrays 
                int now_element = 0;
                // теперь, когда мы выделили массив необходимого размера, 
                // мы заполним его необходимыми значениями 
                for ( int ax = 0; ax < Width; ax++)
                {
                    for ( int bx = 0; bx < Heigth; bx++)
                    {
                        // если точка в координатах ax,bx не помечена флагом "прозрачная" 
                        // если данная точка НЕ помечена флагом, сигнализирующим о том, что она не должна быть визуализирована 
                        if (DrawPlace[ax, bx, 3] != 1)
                        {
                            // заносим координаты точки (ax , bx) в массив, который будет передан для визуализации 
                            arr_date_vertex[now_element * 2] = ax; arr_date_vertex[now_element * 2 + 1] = bx;
                            // заносим значения составляющих цвета, сразу перенося их в формат float 
                            arr_date_colors[now_element * 3] = ( float )DrawPlace[ax, bx, 0] / 255.0f;
                            arr_date_colors[now_element * 3 + 1] = ( float )DrawPlace[ax, bx, 1] / 255.0f;
                            arr_date_colors[now_element * 3 + 2] = ( float )DrawPlace[ax, bx, 2] / 255.0f;
                            // подсчет добавленных элементов в массивы 
                            now_element++;
                        }
                    }
                } // теперь, когда массивы с геометрическими данными и данными о цветах подготовлены, 
                  // включаем функцию использования массивов вершин и цветов 
                Gl.glEnableClientState( Gl.GL_VERTEX_ARRAY);
                Gl.glEnableClientState( Gl.GL_COLOR_ARRAY);
                // передаем массивы вершин и цветов, указывая количество элементов массива, приходящихся 
                // на один визуализируемый элемент (в случае точек - 2 координаты: х и у, в случае цветов - 3 составляющие цвета) 
                Gl.glColorPointer(3, Gl.GL_FLOAT, 0, arr_date_colors);
                Gl.glVertexPointer(2, Gl.GL_INT, 0, arr_date_vertex);
                // вызываем функцию glDrawArrays которая позволит нам визуализировать наши массивы, передав их целиком,
                // а не передавая в цикле каждую точку 
                Gl.glDrawArrays( Gl.GL_POINTS, 0, count);
                // деактивируем режим использования массивов геометрии и цветов 
                Gl.glDisableClientState( Gl.GL_VERTEX_ARRAY);
                Gl.glDisableClientState( Gl.GL_COLOR_ARRAY);
            }
                
        }
        // установка текущего цвета для рисования в слое 
        public void SetColor(Color NewColor)
        {
            ActiveColor = NewColor;
        }
        // получение текущего активного цвета 
        public Color GetColor()
        {
            // возвращаем цвет 
            return ActiveColor;
        }
        // функции удаления слоя 
        public void ClearList()
        {
            // проверяем факт существования дисплейного списка с номером, хранимым в ListNom 
            if ( Gl.glIsList(ListNom) == Gl.GL_TRUE)
            {
                // удаляем его в случае существования 
                Gl.glDeleteLists(ListNom,1);
            }
        }
        public void CreateNewList()
        {
            // проверяем факт существования дисплейного списка с номером, хранимым в ListNom 
            if ( Gl.glIsList(ListNom) == Gl.GL_TRUE)
            {
                // удаляем его в случае существования 
                Gl.glDeleteLists(ListNom,1);
                // и генерируем новый номер 
                ListNom = Gl.glGenLists(1);
            }
            // создаем дисплейный список 
            Gl.glNewList(ListNom, Gl.GL_COMPILE);
            // вызывая обычную визуализацию (не из списка) 
            RenderImage( false );
            // завершаем создание дисплейного списка 
            Gl.glEndList();
        }
        
           
    }
}
