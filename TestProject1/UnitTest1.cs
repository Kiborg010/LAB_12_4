using ClassLibrary1;
using LAB_12_4;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MyCollectionInitialWithoutParametrs()
        {
            MyCollection<Car> cars = new MyCollection<Car>();
            Assert.AreEqual(cars.tableValue.Length, 1);
        }

        [TestMethod]
        public void MyCollectionInitialWithNegativeLenght()
        {
            string text = " ";
            try
            {
                MyCollection<Car> cars = new MyCollection<Car>(-5);
            }
            catch (Exception ex)
            {
                text = ex.Message;
            }
            Assert.AreEqual(text, "В хэш-таблице не может быть отрицательное количество элементов");
        }

        [TestMethod]
        public void MyCollectionInitialWithpositiveLenght()
        {
            MyCollection<Car> cars = new MyCollection<Car>(3);
            Assert.AreEqual(cars.Capacity, 3);
        }

        [TestMethod]
        public void MyCollectionInitialWithMyCollection()
        {
            MyCollection<Car> cars1 = new MyCollection<Car>(3);
            MyCollection<Car> cars2 = new MyCollection<Car>(cars1);
            Assert.AreEqual(cars2.Capacity, 3);
        }

        [TestMethod]
        public void MyCollectionForEach()
        {
            MyCollection<Car> cars1 = new MyCollection<Car>(3);
            int count = 0;
            foreach (Car car in cars1)
            {
                count++;
            }
            Assert.AreEqual(count, 3);
        }

        [TestMethod]
        public void AddToMyCollection()
        {
            MyCollection<Car> cars1 = new MyCollection<Car>(1);
            cars1.Add(new Car());
            Assert.AreEqual(cars1.Capacity, 2);
        }

        [TestMethod]
        public void ClearMyCollection()
        {
            MyCollection<Car> cars1 = new MyCollection<Car>(3);
            cars1.Clear();
            Assert.AreEqual(cars1.Count, 0);
        }

        [TestMethod]
        public void MyCollectionCopyToOne()
        {
            MyCollection<Car> cars = new MyCollection<Car>(4);
            Car[] array = new Car[cars.Capacity];
            cars.CopyTo(array, 0);
            Assert.IsTrue(array.Contains(null));
        }

        [TestMethod]
        public void MyCollectionCopyToTwo()
        {
            MyCollection<Car> cars = new MyCollection<Car>(4);
            Car[] array = new Car[cars.Capacity];
            cars.CopyTo(array, 1);
            Assert.IsTrue(array.Contains(null));
        }

        [TestMethod]
        public void MyCollectionRemove()
        {
            MyCollection<Car> cars = new MyCollection<Car>();
            Car car1 = new Car();
            cars.Add(car1);
            cars.Remove(car1);
            Assert.IsTrue(!cars.Contains(car1));
        }
    }
}