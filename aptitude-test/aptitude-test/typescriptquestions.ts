import 'reflect-metadata';

class MathClass {
  @subtract(1)
  @multiply(2)
  addOne(number: number) {
    return number + 1;
  }
}

function subtract(number = 1) {
  return function (
    target: any,
    propertyKey: string,
    descriptor: PropertyDescriptor
  ) {
    Reflect.defineMetadata('overridenName', true, target, propertyKey);

    const originalMethod = descriptor.value;
    descriptor.value = function (...args: number[]) {
      console.log('sub args :', args);
      args[0] = args[0] - number;
      console.log('sub args :', args);
      return originalMethod.apply(this, args);
    };
    return descriptor;
  };
}

function multiply(number = 1) {
  return function (
    target: any,
    propertyKey: string,
    descriptor: PropertyDescriptor
  ) {
    Reflect.defineMetadata('overridenName', true, target, propertyKey);

    const originalMethod = descriptor.value;
    descriptor.value = function (...args: number[]) {
      console.log('mul args :', args);
      args[0] = args[0] * number;
      console.log('sub args :', args);
      return originalMethod.apply(this, args);
    };
    return descriptor;
  };
}


const my = new MathClass();
console.log(my.addOne(2));



// ES6 Import
//type 1:
// correct answer is answer2, answer4
// type 2 
// no answers is correct