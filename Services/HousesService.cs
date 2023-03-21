using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GregslistCSharp.Services;

public class HousesService
{
    private readonly HousesRepository _repo;
    public HousesService(HousesRepository repo)
    {
        _repo = repo;
    }

    internal List<House> Find()
    {
        List<House> houses = _repo.FindAll();
        return houses;
    }

    internal House Find(int id)
    {
        House house = _repo.FindOne(id);
        if (house == null) throw new Exception($"No House with that id: {id}");
        return house;
    }
    internal House Create(House houseData)
    {
        House house = _repo.Create(houseData);
        return house;
    }

    internal string Remove(int id)
    {
        House house = this.Find(id);
        bool result = _repo.Remove(id);
        if (!result) throw new Exception($"Something went terribly wrong when you deleted.");
        return $"You deleted {house.Address} at {house.Price}";
    }

    internal House Update(House updateData)
    {
        House original = this.Find(updateData.Id);
        original.Room = updateData.Room != 0 ? updateData.Room : original.Room;
        original.Bathroom = updateData.Bathroom != 0 ? updateData.Bathroom : original.Bathroom;
        original.Year = updateData.Year != 0 ? updateData.Year : original.Year;
        original.Price = updateData.Price != 0 ? updateData.Price : original.Price;
        original.ImgUrl = updateData.ImgUrl != null ? updateData.ImgUrl : original.ImgUrl;
        original.Color = updateData.Color != null ? updateData.Color : original.Color;
        original.Address = updateData.Address != null ? updateData.Address : original.Address;
        original.Description = updateData.Description != null ? updateData.Description : original.Description;
        int rowsAffected = _repo.Update(original);
        if (rowsAffected == 0) throw new Exception($"Could not modify {updateData.Address}");
        if (rowsAffected > 1) throw new Exception($"Something terrible happened! Check DB for {updateData.Address}");
        return original;
    }
}
