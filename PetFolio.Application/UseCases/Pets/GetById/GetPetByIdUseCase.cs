using PetFolio.Communication.Responses;

namespace PetFolio.Application.UseCases.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Athena",
            Birthday = new DateTime(year: 2023, month: 2, day: 14),
            Type = Communication.Enums.PetType.Dog
        };
    }
}
