using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class BlockchainController : BaseController
{
    private readonly IUnityOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BlockchainController(IUnityOfWork unitOfWork,IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Cliente>>> Get()
    {
        var blockchain = await _unitOfWork.Cargo.GetAllAsync();
        return _mapper.Map<List<CargoDto>>(*);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CargoDto>> Get(int id)
    {
        var blockchain = await _unitOfWork.Cargo.GetByIdAsync(id);
        if(blockchain == null)
        {
            return NotFound();
        }
        return _mapper.Map<CargoDto>(blockchain);
    }
   

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(int id)
    {
        var blockchain = await _unitOfWork.Cargo.GetByIdAsync(id);
        if(blockchain == null)
            return NotFound();
        _unitOfWork.Cargo.Remove(blockchain);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }

}
