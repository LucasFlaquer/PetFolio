using PetFolio.Communication.Responses;

namespace PetFolio.Application.UseCases.Pets.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetsJson Execute()
    {
        return new ResponseAllPetsJson
        {
            Pets = [
                new ResponseShortPetJson
                {
                    Id = 1,
                    Name = "Fido",
                    Type = Communication.Enums.PetType.Dog
                },
                new ResponseShortPetJson
                {
                    Id = 2,
                    Name = "Whiskers",
                    Type = Communication.Enums.PetType.Cat
                }
            ]
        };
    }
}
