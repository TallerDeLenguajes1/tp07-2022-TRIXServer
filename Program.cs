
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

char flagBuscar;
string buscar;

System.Console.WriteLine($"--\tBuscar Tarea");
System.Console.WriteLine("--");
System.Console.Write("Buscar tarea (S - SI, N - NO): ");
flagBuscar = char.ToUpper(Console.ReadKey().KeyChar);
System.Console.WriteLine();

while (flagBuscar == 'S')
{
    System.Console.Write("Ingrese la descripcion a buscar: ");
    buscar = Console.ReadLine();
    System.Console.WriteLine("--");

    tarea tareaBuscar = null;

    foreach (var item in tareasPendientes)
    {
        if ((item.Descripcion.ToLower()).Contains(buscar.ToLower()))
        {
            tareaBuscar = item;
            break;

        }
    }

    if (tareaBuscar == null)
    {
        foreach (var item in tareasRealizadas)
        {
            if ((item.Descripcion.ToLower()).Contains(buscar.ToLower()))
            {
                tareaBuscar = item;
                break;

            }
        }
    }

    System.Console.WriteLine($"Tarea que contiene: {tareaBuscar}");

    if (tareaBuscar != null)
    {
        System.Console.WriteLine($"Id Tarea: \t{tareaBuscar.IdTarea}");
        System.Console.WriteLine($"Descripcion: \t{tareaBuscar.Descripcion}");
        System.Console.WriteLine($"Duracion: \t{tareaBuscar.Duracion} minutos");
        System.Console.WriteLine("--");
    }
    else
    {
        System.Console.WriteLine("No hay tareas con ese termino");
        System.Console.WriteLine("--");

    }

    System.Console.Write("Buscar tarea (S - SI, N - NO): ");
    flagBuscar = char.ToUpper(Console.ReadKey().KeyChar);
    System.Console.WriteLine();
    
}

int horasTrabajadas = duracionTotal / 60;
int minutosTrabajados = duracionTotal % 60;

System.Console.WriteLine($"El empleado trabajo: {horasTrabajadas} horas y {minutosTrabajados} minutos");
