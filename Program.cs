/* En tu clase de programa, crea una instancia de un objeto Buffet y Ninja, ¡y haz que el Ninja coma hasta que esté lleno! */
Buffet buffet = new Buffet();

List<Comida> comidas = new List<Comida>();

Ninja ninja = new Ninja();

int i = 0;

while(!ninja.EstaLleno){
  comidas.Add(buffet.Servir());
  ninja.Comer(comidas[i]);
  i++;
}

comidas.Add(buffet.Servir());
ninja.Comer(comidas[i]);