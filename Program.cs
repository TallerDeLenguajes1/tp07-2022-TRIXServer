
var random = new Random();
int cantidadTareas = random.Next(2, 10);
Console.Clear();
System.Console.WriteLine($"--\tTotal Tareas: {cantidadTareas}");
System.Console.WriteLine("--");

var tareasPendientes = new List<tarea>();
var tareasRealizadas = new List<tarea>();
int idTarea;
int duracion;
string descripcion;

for (int i = 0; i <cantidadTareas; i++)
{
    System.Console.WriteLine($"--\tTarea {i + 1}");
    System.Console.Write("Ingrese la descripcion: ");
    descripcion = Console.ReadLine();
    System.Console.WriteLine("--");
    idTarea = i + 1;
    duracion = random.Next(10,100);
    var tarea = new tarea(idTarea, duracion, descripcion);

    tareasPendientes.Add(tarea);

}

char flagTarea;

System.Console.WriteLine($"--\tTareas Pendientes");
System.Console.WriteLine("--");
for (int i = tareasPendientes.Count - 1; i >= 0; i--)
{
    System.Console.WriteLine($"id Tarea: \t{tareasPendientes[i].IdTarea}");
    System.Console.WriteLine($"Descripcion: \t{tareasPendientes[i].Descripcion}");
    System.Console.WriteLine($"Duracion: \t{tareasPendientes[i].Duracion} minutos");
    System.Console.WriteLine("--");
    System.Console.Write("Tarea Realizada (S - SI, N - NO): ");
    flagTarea = char.ToUpper(Console.ReadKey().KeyChar);
    System.Console.WriteLine("");

    if (flagTarea == 'S')
    {
        System.Console.WriteLine("--\tMoviendo Tarea...");
        tareasRealizadas.Add(tareasPendientes[i]);
        tareasPendientes.RemoveAt(i);

    }

    System.Console.WriteLine("--");

}

System.Console.WriteLine($"--\tTareas Pendientes");
System.Console.WriteLine("--");

foreach (var tareaPendiente in tareasPendientes)
{
    System.Console.WriteLine($"id Tarea: \t{tareaPendiente.IdTarea}");
    System.Console.WriteLine($"Descripcion: \t{tareaPendiente.Descripcion}");
    System.Console.WriteLine($"Duracion: \t{tareaPendiente.Duracion} minutos");
    System.Console.WriteLine("--");

}

int duracionTotal = 0;
System.Console.WriteLine($"--\tTareas Realizadas");
System.Console.WriteLine("--");

foreach (var tareaRealizada in tareasRealizadas)
{
    System.Console.WriteLine($"id Tarea: \t{tareaRealizada.IdTarea}");
    System.Console.WriteLine($"Descripcion: \t{tareaRealizada.Descripcion}");
    System.Console.WriteLine($"Duracion: \t{tareaRealizada.Duracion} minutos");
    System.Console.WriteLine("--");
    duracionTotal += tareaRealizada.Duracion;
    
}

