using LHPets.Models;
using Microsoft.AspNetCore.Mvc;

namespace LHPets.Controllers;

[ApiController]
[Route("api/clientes")]

public class ClientesController : ControllerBase
{
    //Lista estática para armazenar os clientes cadastrados.
    public static
     List<Cliente> Clientes { get; } = new List<Cliente>();

    [HttpGet]
    public ActionResult<List<Cliente>> ListarClientes()
    {
        return Ok(Clientes);
    }

    [HttpPost]
    public ActionResult<Cliente> CadastrarCliente(Cliente cliente)
    {
        cliente.Id = Clientes.Count + 1; // Atribui um ID único ao cliente.
        Clientes.Add(cliente);
        return StatusCode(201, cliente); // Retorna o cliente cadastrado com status 201 (Created).
    }
}