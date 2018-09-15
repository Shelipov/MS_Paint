using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Paint
{
    // класс, реализующий "ядро" нашего растрового редактора. 
    public class anEngine
    {
        // последний установленный цвет 
        private Color LastColorInUse;
        
        // размеры изображения 
        private int picture_size_x , picture_size_y;
        // положение полос прокрутки будет использовано в будущем 
        private int scroll_x, scroll_y;
        // размер оконной части (объекта AnT) 
        private int screen_width, screen_height;
        // номер активного слоя 
        private int ActiveLayerNom;
        // массив слоев 
        private ArrayList Layers = new ArrayList();
        // стандартная кисть 
        private anBrush standartBrush;
        // конструктор класса 
        public anEngine(int size_x, int size_y, int screen_w, int screen_h)
        {
            // при инициализации экземпляра класса сохраним настройки 
            // размеров элементов и изображения в локальных переменных 
            picture_size_x = size_x;
            picture_size_y = size_y;
            screen_width = screen_w;
            screen_height = screen_h;
            // полосы прокрутки у нас пока отсутствуют, поэтому просто обнулим значение переменных 
            scroll_x = 0;
            scroll_y = 0;
            // добавим новый слой для работы, пока он будет единственным 
            Layers.Add( new anLayer(picture_size_x, picture_size_y) );
            // номер активного слоя - 0 
            ActiveLayerNom = 0;
            // и создадим стандартную кисть 
            standartBrush = new anBrush(3,false);
        }
        // функция для установки номера активного слоя 
        public void SetActiveLayerNom(int nom)
        {
            //// новый активный слой получает установленный активный цвет для предыдущего активного слоя 
            //((anLayer)Layers[nom]).SetColor( ((anLayer)Layers[ActiveLayerNom]).GetColor() );

            // текущий слой больше не будет активным, следовательно, надо создать новый дисплейный список для его быстрой визуализации 
            ((anLayer)Layers[ActiveLayerNom]).CreateNewList();
            // новый активный слой получает установленный активный цвет для предыдущего активного слоя 
            ((anLayer)Layers[nom]).SetColor( ((anLayer)Layers[ActiveLayerNom]).GetColor() );
            
            // установка номера активного слоя 
            ActiveLayerNom = nom;
            
        }
        // установка видимости / невидимости слоя 
        public void SetWisibilityLayerNom(int nom, bool visible)
        {
            // вернемся к этой функции позже
        }
        // рисование текущей кистью 
        public void Drawing(int x, int y)
        {
            // транслируем координаты, в которых проходит рисование стандартной кистью 
            ((anLayer)Layers[ActiveLayerNom]).Draw(standartBrush, x, y);
            
        }
        // визуализация 
        public void SwapImage()
        {
            //// вызываем функцию визуализации в нашем слое для всех существующих слоев 
            //for ( int ax = 0; ax < Layers.Count; ax++)
            //    ((anLayer)Layers[ax]).RenderImage();
            // вызываем функцию визуализации в нашем слое 
            for ( int ax = 0; ax < Layers.Count; ax++)
            {
                // если данный слой является активным в данный момент, 
                if ( ax == ActiveLayerNom)
                { // вызываем визуализацию данного слоя напрямую 
                    ((anLayer)Layers[ax]).RenderImage( false );
                }
                else
                {
                    // вызываем визуализацию слоя из дисплейного списка 
                    ((anLayer)Layers[ax]).RenderImage( true );
                }
            }
        }
        // функция установки стандартной кисти, передается только размер 
        public void SetStandartBrush(int SizeB)
        {
            standartBrush = new anBrush(SizeB, false);
        }
        // функция установки специальной кисти 
        public void SetSpecialBrush(int Nom)
        {
            standartBrush = new anBrush(Nom, true);
        }
        // установка кисти из файла 
        public void SetBrushFromFile(string FileName)
        {
            standartBrush = new anBrush(FileName);
        }
        // функция установки активного цвета 
        public void SetColor(Color NewColor)
        {
            ((anLayer)Layers[ActiveLayerNom]).SetColor(NewColor);
            LastColorInUse = NewColor;
            
        }
        // функция добавления слоя 
        public void AddLayer()
        {
            // добавляем слой в массив слоев ArrayList 
            int AddingLayer = Layers.Add( new anLayer(picture_size_x, picture_size_y));
            // устанавливаем его активным 
            SetActiveLayerNom(AddingLayer);
        }
        // функция удаления слоев 
        public void RemoveLayer( int nom)
        {
            // если номер корректен (в диапазоне добавленных в ArrayList 
            if (nom < Layers.Count && nom >= 0)
            {
                // делаем активным слой 0 
                SetActiveLayerNom(0);
                // очищаем дисплейный список данного слоя 
                ((anLayer)Layers[nom]).ClearList();
                // удаляем запись о слое 
                Layers.RemoveAt(nom);
            }
        }
        // получение финального изображения 
        public Bitmap GetFinalImage()
        {
            // заготовка результирующего изображения 
            Bitmap resaultBitmap = new Bitmap(picture_size_x, picture_size_y);
            // данное решение также не является оптимальным по быстродействию, 
            //но при этом является самым простым способом решения задачи 
            for ( int ax = 0; ax < Layers.Count; ax++)
            {
                // получаем массив пикселей данного слоя 
                int [,,] tmp_layer_data = ((anLayer)Layers[ax]).GetDrawingPlace();
                // пройдем двумя циклами по информации о пикселях данного слоя 
                for ( int a = 0; a < picture_size_x; a++)
                {
                    for ( int b = 0; b < picture_size_y; b++)
                    {
                        // в случае, если пиксель не помечен как "прозрачный", 
                        if (tmp_layer_data[a, b, 3] != 1)
                        {
                            // устанавливаем данный пиксель на результирующее изображение 
                            resaultBitmap.SetPixel(a,b, Color.FromArgb(tmp_layer_data[a, b, 0], tmp_layer_data[a, b, 1], tmp_layer_data[a, b, 2]));
                        }
                        else
                        {
                            if (ax == 0)
                            // нулевой слой - необходимо закрасить белым отсутствующие пиксели 
                            {
                                // закрашиваем белым цветом 
                                resaultBitmap.SetPixel(a, b, Color.FromArgb(255, 255, 255));
                            }
                        }
                    }
                }
            } // поворачиваем изображение для корректного отображения 
            resaultBitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
            // возвращаем результат 
            return resaultBitmap;
        }
        // получение изображения для главного слоя 
        public void SetImageToMainLayer(Bitmap layer)
        {
            // поворачиваем изображение (чтобы оно корректно отображалось в области редактирования). 
            layer.RotateFlip(RotateFlipType.Rotate180FlipX);
            // проходим 2-мя циклами по всем пикселям изображения, загруженного в класс Bitmap 
            // получая цвет пикселя, устанавливаем его в текущий слой с помощью функции Drawing 
            // данный алгоритм является крайне медленным, но при этом и крайне простым. 
            // оптимальным решением здесь будет написание собственного загрузчика файлов изображений 
            // что даст возможность без "посредников" получать массив значений пикселей изображений 
            // но данная задача является на много более сложной, а для обучения мы идем более легкими путями 
            for ( int ax = 0; ax < layer.Width; ax++)
            {
                for ( int bx = 0; bx < layer.Height; bx++)
                { // получение цвета пикселя изображения 
                    SetColor(layer.GetPixel(ax,bx));
                    // отрисовка данного пикселя в слое 
                    Drawing(ax, bx);
                }
            }
        } 
        
        
        
    }
    
}
