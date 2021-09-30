# FizzBuss
FizzBuss Chalange

I received this chalange on an interview but the interviwer asked me to use the strategy pattern and since I can't let an oportunity to write some code pass, I actually create and solution for that.

One of the things I like more when I decide to use strategy pattern on my code is the simplicity of a switch statment:

```
return type switch
        {
            ActionType.FizzBuss => new FizzBussAction(),
            ActionType.Fizz => new FizzAction(),
            ActionType.Buss => new BussAction(),
            _ => new DefaultAction(),
        };
```


By the way, the challenge asked to not print the number when printing Fizz, Buss or FizzBuss, but I couldn't do that, I love to see the number as some sort of enumeration to let me know witch item are has been processed.
