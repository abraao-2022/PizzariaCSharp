using PizzariaCSharp.Controller;
using PizzariaCSharp.Enums;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository;

Console.WriteLine("Simulando API");
System.Console.WriteLine();

var controllerBebida = new BebidaController(new BebidaRepository());
var controllerSabor = new SaborController(new SaborRepository());
var controllerPizza = new PizzaController(new PizzaRepository());
var controllerCliente = new ClienteController(new ClienteRepository());
var controllerPedido = new PedidoController(new PedidoRepository());

var bebida1 = controllerBebida.Adicionar(new Bebida("Coca Cola 2lt", 10));
var bebida2 = controllerBebida.Adicionar(new Bebida("H2O Limoneto", 10));

var sabor1 = controllerSabor.Adicionar(new Sabor("4 Queijos", ""));
var sabor2 = controllerSabor.Adicionar(new Sabor("Portuguesa", ""));
var sabor3 = controllerSabor.Adicionar(new Sabor("Calabresa", ""));
var sabor4 = controllerSabor.Adicionar(new Sabor("Frango com Catupiry", ""));

var cliente1 = controllerCliente.Adicionar(new Cliente() { Nome = "Jose francisco", Telefone = "021999999999" });
var cliente2 = controllerCliente.Adicionar(new Cliente() { Nome = "Renato Silveira", Telefone = "021999999988" });

var pizza1 = new Pizza(ETipoPizza.GIGANTE, ETipoBorda.COM_CHEDDAR, 40, new List<Sabor>() { sabor1, sabor2 });
var pizza2 = new Pizza(ETipoPizza.SUPER_GIGANTE, ETipoBorda.SEM_BORDA, 50, new List<Sabor>() { sabor2, sabor3 });
var pizza3 = new Pizza(ETipoPizza.MEDIA, ETipoBorda.COM_GORGONZOLA, 35, new List<Sabor>() { sabor4 });
var pizza4 = new Pizza(ETipoPizza.GIGANTE, ETipoBorda.COM_MUSSARELA, 40, new List<Sabor>() { sabor3 });


var pedido1 = new Pedido(cliente1);

var valor1 = pedido1
    .AdicionarBebida(bebida1)
    .AdicionarBebida(bebida2)
    .AdicionarPizza(pizza1)
    .AdicionarPizza(pizza2)
    .ObterValorTotal();
pedido1.FinalizarPedido();
controllerPedido.Adicionar(pedido1);

var pedido2 = new Pedido(cliente1);
var valor2 = pedido2
    .AdicionarBebida(bebida2)
    .AdicionarPizza(pizza4)
    .ObterValorTotal();
pedido2.FinalizarPedido();
controllerPedido.Adicionar(pedido2);
