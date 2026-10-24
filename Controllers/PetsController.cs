using LHPets.Models;
using Microsoft.AspNetCore.Mvc;

namespace LHPets.Controllers;

[ApiController]
[Route("api/pets")]
public class PetsController : ControllerBase
{
    
    //Lista estática para armazenar os pets cadastrados.
    public static
     List<Pet> Pets { get; } = new List<Pet>();

    [HttpGet]
    public ActionResult<List<Pet>> ListarPets()
    {
        return Ok(Pets);
    }

    [HttpPost]
    public ActionResult<Pet> CadastrarPet(Pet pet)
    {
        var verificarTutor = ClientesController.Clientes.Any(cliente => cliente.Id == pet.ClienteId); // Verifica se existe algum cliente com o ID informado.
        if(!verificarTutor)
        {
            return BadRequest("O cliente informado não está cadastrado.");
        }
        
        pet.Id = Pets.Count + 1; // Atribui um ID único ao pet.
        Pets.Add(pet);
        return StatusCode(201, pet); // Retorna o pet cadastrado com status 201 (Created).
    }

    [HttpGet("cliente/{clienteId:int}")]
    public ActionResult<List<Pet>> ListarPetsPorTutor(int clienteId)
    {
        var petsDoTutor = Pets.Where(pet => pet.ClienteId == clienteId).ToList();
        return Ok(petsDoTutor);
    }
}