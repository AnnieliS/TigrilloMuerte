INCLUDE globals.ink
-> main

=== main ===

How's it hanging? #speaker:Rosa #portrait:Rosa #color:1,1,1,1
Was that a pun? #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
    +[yes]
        -> yes
    +[maybe]
        -> maybe
    +[NO]
        -> no

=== yes ===
Well at least it's less dull than doing nothing #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
What can I help with? #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
     +[Herbs]
        -> herbs
    +[Headress]
        -> headress
    +[Knife]
        ->knife

=== herbs ===
Do you know anything about ceremonial herbs around? #speaker:Rosa #portrait:Rosa #color:1,1,1,1
Oh yeah! #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
A log! Just west of here have some! #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
A log? #speaker:Rosa #portrait:Rosa #color:1,1,1,1
Yeah yeah a log with some mushrooms on it #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
I once saw a priest hiding some herbs in there #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
Oh #speaker:Rosa #portrait:Rosa #color:1,1,1,1
Don't know if they're still there, or still holy #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
~canHerbs = true
Anything else? #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
    +[please]
        ->yes
    +[no thanks]
        ->finish

===headress===
Why would I know anything about that? #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
You asked me what to help with #speaker:Rosa #portrait:Rosa #color:1,1,1,1
Well not that. #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
Anything else? #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
    +[sure]
        ->yes
    +[no thanks]
        ->finish
        
===knife===
I'm not sure #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
What do you mean? #speaker:Rosa #portrait:Rosa #color:1,1,1,1
When I was a baby I think I saw someone sacrifice an animal near by #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
But I honestly can't remember #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
I'll ask around #speaker:Rosa #portrait:Rosa #color:1,1,1,1
Anything else? #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
    +[yes please]
        ->yes
    +[no thanks]
        ->finish

=== maybe ===
... #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
... #speaker:Rosa #portrait:Rosa #color:1,1,1,1
... #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
...Try again lassy #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
-> END

=== no ===
... #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
UGH #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
One of those. #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1
... #speaker:Rosa #portrait:Rosa #color:1,1,1,1
    ->yes


===finish===
Not really. #speaker:Rosa #portrait:Rosa #color:1,1,1,1
Well, do stop by again sometimes #speaker:Bat #portrait:Bat #color:0.7,0.35,0,1

-> END