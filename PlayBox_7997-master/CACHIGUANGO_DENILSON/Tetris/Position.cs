namespace Tetris
{
    public class Position
    {
        //Para representar un posición o celda en una cuadr{icula
        //Almacenar una fila y una columna
        //line1
        public int Ron { get; set; }
        public int Colum { get; set; }
        //Agregar un construcor simple
        public Position(int row, int column)
        {
            Ron = row ;
            Colum = Colum;
        }
    }
}
