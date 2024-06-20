# Библиотека Shapes

Библиотека Shapes предоставляет возможность работы с двумерными и трехмерными геометрическими фигурами. Она включает в себя реализации для круга, треугольника, пирамиды и сферы.

## Как использовать

### Создание фигур

Чтобы создать экземпляр любой фигуры, используйте статический класс `ShapeFactory`.

#### Примеры:

1. **Создание круга:**

```csharp
using Shapes;
using Shapes.Shapes2D;

// Создание круга с радиусом 5
IShape2D circle = ShapeFactory.CreateCircle(5);

// Получение площади круга
decimal area = circle.Area;
Console.WriteLine($"Площадь круга: {area}");
```

2. **Создание треугольника:**

```csharp
using Shapes;
using Shapes.Shapes2D;

// Создание треугольника со сторонами 3, 4, 5
IShape2D triangle = ShapeFactory.CreateTriangle(3, 4, 5);

// Получение площади треугольника
decimal area = triangle.Area;
Console.WriteLine($"Площадь треугольника: {area}");
```

3. **Создание пирамиды:**

```csharp
using Shapes;
using Shapes.Shapes3D;

// Создание пирамиды с площадью основания 10, периметром основания 12 и высотой 8
IShape3D pyramid = ShapeFactory.CreatePyramid(10, 12, 8);

// Получение площади поверхности и объема пирамиды
decimal area = pyramid.Area;
decimal volume = pyramid.Volume;
Console.WriteLine($"Площадь поверхности пирамиды: {area}");
Console.WriteLine($"Объем пирамиды: {volume}");
```

4. **Создание сферы:**

```csharp
using Shapes;
using Shapes.Shapes3D;

// Создание сферы с радиусом 6
IShape3D sphere = ShapeFactory.CreateSphere(6);

// Получение площади поверхности и объема сферы
decimal area = sphere.Area;
decimal volume = sphere.Volume;
Console.WriteLine($"Площадь поверхности сферы: {area}");
Console.WriteLine($"Объем сферы: {volume}");
```

### Добавление новых фигур

Для добавления новых фигур в библиотеку Shapes:

1. **Создайте новый класс для фигуры:**

   - Реализуйте интерфейс `IShape2D` для двумерной фигуры или `IShape3D` для трехмерной фигуры в пространстве имен `Shapes.Shapes2D` или `Shapes.Shapes3D` соответственно.

2. **Добавьте метод в `ShapeFactory`:**

   - В статическом классе `ShapeFactory` добавьте метод для создания новой фигуры, используя ваш класс. Это позволит пользователям вашей библиотеки создавать экземпляры новой фигуры таким же образом, как и существующих.

3. **Обновите README:**

   - Документируйте новую фигуру в README, предоставив примеры её использования аналогично уже существующим фигурам.

### Зависимости

Библиотека не имеет внешних зависимостей и должна работать в любом проекте, поддерживающем .NET Standard 2.0 и выше.