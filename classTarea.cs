class tarea
{
    int idTarea;
    int duracion;
    string descripcion;

    public tarea()
    {
    }

    public tarea(int dataIdTarea, int dataDuracion, string dataDescripcion)
    {
        IdTarea = dataIdTarea;
        Duracion = dataDuracion;
        Descripcion = dataDescripcion;

    }

    public int IdTarea { get => idTarea; set => idTarea = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
}
