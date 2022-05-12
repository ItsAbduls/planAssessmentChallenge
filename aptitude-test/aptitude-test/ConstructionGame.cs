using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptitude_test
{
    public class BuildingEntity
    {
        public BuildingEntity()
        {
            _gameHouse = new List<string>() { "Kitchen" };
        }
        public List<string> _gameHouse = new List<string>();

        public string Describe()
        {
            return String.Join(",", _gameHouse);
        }
    }
    public abstract class BuildingBuilder
    {
        protected BuildingEntity _building;
        public BuildingBuilder()
        {
            _building = new BuildingEntity();
        }
        public BuildingEntity Build() => _building;
    }

    public class BuildingAddKitchenBuilder<T> : BuildingBuilder where T : BuildingAddKitchenBuilder<T>
    {
        public T AddKitchen()
        {
            _building._gameHouse.Add($"Kitchen");
            return (T)this;
        }
    }
    public class BuildingAddBedroomBuilder<T> : BuildingAddKitchenBuilder<BuildingAddBedroomBuilder<T>> where T : BuildingAddBedroomBuilder<T>
    {
        public T AddBedroom(string value)
        {
            _building._gameHouse.Add($"{value} room");
            return (T)this;
        }
    }

    public class BuildingAddbolconyBuilder<T> : BuildingAddBedroomBuilder<BuildingAddbolconyBuilder<T>> where T : BuildingAddbolconyBuilder<T>
    {
        public T AddBolcony()
        {
            _building._gameHouse.Add($"bolcony");
            return (T)this;
        }
    }

    public class Building : BuildingAddbolconyBuilder<Building>
    {
        public static Building NewEmployee => new Building();
    }

}
