using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int assholeFactor = 0;
            int niceFactor = 0;
            int userHealth = 10;
            int machineHealth = 15;
            bool techSavvy = false;

            // Boss battle stuff
            Random kat = new Random();
            Random fridge = new Random();
            Random machine = new Random();

            // THE CONSOLE WINDOW AUTO-SCROLLS AND IT'S EASY TO GET LOST 
            // SO LOOK FOR THE DOUBLE ARROWS (>>) WHEN LOOKING FOR WHERE
            // YOU LAST ENTERED YOUR CHOICE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            // Start scene 1
            Console.WriteLine("-------------------------REALITY BYTES-------------------------");
            Console.WriteLine();
            Console.WriteLine("Scene One - The Restaurant");
            Console.WriteLine();

            // Scene 1 description
            Console.WriteLine("\"If a machine can be created that has intelligence, could it also feel? \n And if it can feel, does it have the same rights as a human?\"");
            Console.WriteLine();
            Console.WriteLine("A busboy arrives at the table to collect your remaining plates. \n It is the 10th anniversary of your marriage and you and your significant \n other, Sam, decided to indulge yourselves in a luxurious night filled \n with fine wine and overpriced food at a high class restaurant in the city.");
            Console.WriteLine();
            Console.WriteLine("\"Are you finished with this?,\" the busboy asks, pointing at your remaining \n lobster tail.");
            Console.WriteLine();
            Console.WriteLine("\"Yes, that'll be all.\"");
            Console.WriteLine();
            Console.WriteLine("You wait for the busboy to leave before replying, in a rather annoyed voice, \n to Sam.");
            Console.WriteLine();
            Console.WriteLine("\"Jesus Christ. You sound just like one of those liberal humanitarians! \n This is a major breakthrough in science and technology... This is... \n This is the future.\"");
            Console.WriteLine();
            Console.WriteLine("\"I'm sorry, you're right. It was a silly question,\" Sam replies.");
            Console.WriteLine();
            Console.WriteLine("How do you respond?");
            Console.WriteLine();
            Console.WriteLine("RUDELY. I feel like I'm talking to a PEETA affiliate. Machines are not \n conscious beings.");
            Console.WriteLine("NICELY. It was an honest question and I don't want to spoil the mood of \n the night.");
            Console.WriteLine("SILENCE. This doesn't warrant a response.");
            Console.WriteLine();

            // First choice, scene 1 if-statements
            while (1 == 1)
            {
                String firstScene = Console.ReadLine();
                firstScene = firstScene.Trim();
                String firstChoice = firstScene.ToLower();
                Console.WriteLine();

                if (firstChoice == "rudely")
                {
                    assholeFactor++;
                    Console.WriteLine(">>\"You're damn right it was! We've been working on this for years. I thought \n you'd be happy that all those hours at the office actually amounted to \n something.\" (Douche factor increased)");
                    //break;
                }
                if (firstChoice == "nicely")
                {
                    niceFactor++;
                    Console.WriteLine(">>\"No, it wasn't silly. I can see where you're coming from. I suspect there \n will be a lot of people with those same type of questions upon the release \n of the first model.\" (Nice factor increased)");
                    //break;
                }
                if (firstChoice == "silence")
                {
                    userHealth--;
                    Console.WriteLine(">>You sip your wine and say nothing. (Health decreased)");
                    //break;
                }
                if (!(firstChoice == "rudely" || firstChoice == "nicely" || firstChoice == "silence"))
                {
                    Console.WriteLine("That wasn't an option.");
                    continue;
                }

                // Scene 1 description (P.S. This is the rubric equivalent of Scene 2)
                Console.WriteLine();
                Console.WriteLine("The waiter arrives at the table with a dessert menu. You set it down \n unenthusiastically and look Sam straight in the eyes.");
                Console.WriteLine();
                Console.WriteLine("\"Now, I know we said no work talk on our anniversary, but I can't contain my \n excitement any longer. I have been granted the ability to test out a \n prototype. It won't have the full prosthetic body, it'll just be like... \n A super computer. I actually already set it up in the Chinese room. \n You'll love it,\" you say.");
                Console.WriteLine();
                Console.WriteLine("Sam keeps her eyes glued to the dessert menu in her hands. \"You've seen \n '2001: A Space Odyssey, correct?'\"");
                Console.WriteLine();
                Console.WriteLine("How do you respond?");
                Console.WriteLine();
                Console.WriteLine("SARCASTICALLY. Who hasn't seen '2001: A Space Odyssey'? This has no relevance \n to the conversation.");
                Console.WriteLine("UNDERSTANDINGLY. I can understand Sam's concerns. I should reassure her.");
                Console.WriteLine("SILENCE. This doesn't warrant a response.");
                Console.WriteLine();

                // Second choice, scene 1 if-statements (P.S. This is the rubric equivalent of Scene 2, see below)
                while (1 == 1)
                {
                    String secondScene = Console.ReadLine();
                    secondScene = secondScene.Trim();
                    String secondChoice = secondScene.ToLower();
                    Console.WriteLine();

                    if (secondChoice == "sarcastically")
                    {
                        assholeFactor++;
                        Console.WriteLine(">>\"Nope, never heard of that. Ever. Is it a new film? Maybe we should see it \n sometime. That is, if you ever pull that stick out of your ass long enough \n to have a nice time.\" (Douche factor increased)");
                    }

                    if (secondChoice == "understandingly")
                    {
                        niceFactor++;
                        Console.WriteLine(">>\"Look, I know what you're thinking, but this isn't like that. That's science \n FICTION and this is reality. And the reality of the situation is that this is \n an incredible opportunity for me... For us... For science.\" (Nice factor \n increased)");
                    }
                    if (secondChoice == "silence")
                    {
                        userHealth--;
                        Console.WriteLine(">>You sip your wine and say nothing. (Health decreased)");

                        // This lists an option that is only available if the user's firstChoice == "silence"
                        if (userHealth == 8)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Sam notices your silence and your obsessive wine drinking and snatches the \n glass from your hand.");
                            Console.WriteLine();
                            Console.WriteLine("How do you respond?");
                            Console.WriteLine();
                            Console.WriteLine("IRRATIONALLY. I don't have time for this.");
                            Console.WriteLine("RATIONALLY. Clearly Sam is upset. We can work this through.");
                            Console.WriteLine("SILENCE.");
                            Console.WriteLine();

                            String secondScene2 = Console.ReadLine();
                            secondScene2 = secondScene2.Trim();
                            String secondChoice2 = secondScene2.ToLower();
                            Console.WriteLine();

                            if (secondChoice2 == "irrationally")
                            {
                                Console.WriteLine(">>\"IS IT A CRIME TO ENJOY FINE WINE?! WHY ARE YOU ALWAYS TRYING TO UPSET \n ME?!?!? You know what, screw it. I'm done.\"You get up and storm out of the restaurant.");
                                Console.WriteLine();
                                Console.WriteLine("GAME OVER - You failed.");
                                break;
                            }
                            if (secondChoice2 == "rationally")
                            {
                                niceFactor++;
                                Console.WriteLine(">>\"Why are you upset? C'mon, don't be like that. I'm trying extra hard not to \n be an ass today.\" (Nice factor increased)");
                                Console.WriteLine();
                                Console.WriteLine("\"It seems like you're not listening to me,\" Sam exclaims.");
                                Console.WriteLine("\"I'm sorry you feel that way. That's not the case, I'm just tired of fighting,\" you explain.");
                                Console.WriteLine();
                                Console.WriteLine("\"Can we go home?,\" Sam asks.");
                                Console.WriteLine();
                                Console.WriteLine("\"Sure. I was just about to suggest that,\" you reply.");
                            }
                            if (secondChoice2 == "silence")
                            {
                                Console.WriteLine(">>I still have my water glass. Ayy lmao.");
                                Console.WriteLine();
                                Console.WriteLine("You reach for your water glass.");
                                Console.WriteLine();
                                Console.WriteLine("\"Don't you dare,\" Sam says, glaring at you.");
                                Console.WriteLine();
                                Console.WriteLine("You put the glass down.");
                            }
                        }
                    }
                    if (!(secondChoice == "silence" || secondChoice == "sarcastically" || secondChoice == "understandingly"))
                    {
                        Console.WriteLine("That wasn't an option.");
                        continue;
                    }

                    // Scene 1 description
                    Console.WriteLine();
                    Console.WriteLine("You pay the bill and leave without getting dessert as the mood of the night \n has changed.");
                    Console.WriteLine();
                    Console.WriteLine("\"This whole beta testing opportunity is a good thing. You might not \n believe it now, but you will soon,\" you say.");
                    Console.WriteLine();
                    Console.WriteLine("Sam remains silent.");
                    Console.WriteLine();
                    // End scene 1

                    // Start scene 2
                    Console.WriteLine();
                    Console.WriteLine("Scene Two - The Chinese Room");
                    Console.WriteLine();
                    // Scene 2 description
                    Console.WriteLine("You arrive at the house and nervously fumble with your keys at the door.");
                    Console.WriteLine();
                    Console.WriteLine("\"Trust me, you're going to love it,\" you say unconvincingly.");
                    Console.WriteLine();
                    Console.WriteLine("Sam looks uneasily at you but nods in agreement as the two of you enter the \n house.");
                    Console.WriteLine();
                    Console.WriteLine("The two of you make your way to the Chinese room, a room whose décor \n was heavily influenced by Chinese culture and style.");
                    Console.WriteLine();
                    Console.WriteLine("...It seemed like a fitting place to put an AI machine.");
                    Console.WriteLine();
                    Console.WriteLine("You approach the machine and it spurs to life. A green beam emits from the \n machine, scanning your face.");
                    Console.WriteLine();
                    Console.WriteLine("\"Welcome, USER_01,\" the machine says in an atonal voice.");
                    Console.WriteLine();
                    Console.WriteLine("\"Oh, cut it out,\" you respond jokingly to the machine.");
                    Console.WriteLine();
                    Console.WriteLine("\"How was your meal? Did Sam enjoy the restaurant I recommended?,\" \n the machine asked. Only this time, the voice was different. It was human-like.");
                    Console.WriteLine();
                    Console.WriteLine("\"Oh, is that her? How delightful. It's a pleasure to meet you, Sam. \n I have heard a lot about you,\" the machine said.");
                    Console.WriteLine();
                    Console.WriteLine("Sam keeps her eyes glued to the ground.");
                    Console.WriteLine();
                    Console.WriteLine("What do you do?");
                    Console.WriteLine();
                    Console.WriteLine("YELL. I'm tired of this pessimistic  attitude!");
                    Console.WriteLine("ENCOURAGE. I was a little taken aback when I first saw this machine. Sam is \n probably nervous.");
                    Console.WriteLine("SILENCE. Let the machine do the encouraging.");

                    while (1 == 1)
                    {
                        String thirdScene = Console.ReadLine();
                        thirdScene = thirdScene.Trim();
                        String thirdChoice = thirdScene.ToLower();
                        Console.WriteLine();

                        if (thirdChoice == "yell")
                        {
                            assholeFactor++;
                            Console.WriteLine(">>\"Oh, would you stop being a wuss? Just respond to it!\" (Douche factor \n increased)");
                            Console.WriteLine();
                            Console.WriteLine("Without looking up from the ground, Sam runs out of the room.");

                            if (assholeFactor == 3)
                            {
                                userHealth = userHealth - 2;
                                Console.WriteLine();
                                Console.WriteLine(">>Sam approaches you, slaps you across the face, and storms out of the room. \n (Health decreased x2 & Douche factor increased)");
                                Console.WriteLine();
                                Console.WriteLine("\"What the hell has gotten into you?!,\" you yell.");
                            }
                        }
                        if (thirdChoice == "encourage")
                        {
                            niceFactor++;
                            Console.WriteLine(">>\"It's okay, just say \"hi\" or something. The machine is harmless, I swear,\" \n you say. (Nice factor increased)");
                            Console.WriteLine();
                            Console.WriteLine("Without looking up from the ground, Sam runs out of the room.");
                        }
                        if (thirdChoice == "silence")
                        {
                            Console.WriteLine(">>The machine begins to speak, but stops abruptly.");
                            Console.WriteLine("Without looking up from the ground, Sam runs out of the Chinese room.");
                        }
                        if (!(thirdChoice == "silence" || thirdChoice == "encourage" || thirdChoice == "yell"))
                        {
                            Console.WriteLine("That wasn't an option.");
                            continue;
                        }
                        // Scene 2 description
                        Console.WriteLine();
                        Console.WriteLine("\"Don't be like that. It's not going to hurt you!,\" you yell out the door.");
                        Console.WriteLine();
                        Console.WriteLine("You turn back to the machine. \"Sorry about that. She's not usually like this,\" \n you explain.");
                        Console.WriteLine();
                        Console.WriteLine("\"That's quite alright. I'm here whenever...,\" the machine replies.");
                        Console.WriteLine();
                        Console.WriteLine("\"Right. Well, I'm going to go check on Sam. I'll be back soon.\"");
                        Console.WriteLine();
                        Console.WriteLine("\"Uh, wait. Can I bend your ear for a moment?,\" the machine asks.");
                        Console.WriteLine();
                        Console.WriteLine("\"Sure... Hey, where did you coin that phrase?,\" you ask.");
                        Console.WriteLine();
                        Console.WriteLine("\"The net is vast and infinite. Is everyone as obsessed with cats and memes \n in real life as they are on the Internet?,\" asked the machine.");
                        Console.WriteLine();
                        Console.WriteLine("You stifle a laugh.\"Haha, I guess it depends who you hang out with. \n Is that what you wanted to talk about?.\"");
                        Console.WriteLine();
                        Console.WriteLine("\"No. I wanted to know what it's like to be human,\" the machine said in a soft \n voice.");
                        Console.WriteLine();
                        Console.WriteLine("You scrunch your face and look at the ceiling while trying to think of a \n response.\"Gee, I don't know. Being human is like... Existing--\"");
                        Console.WriteLine();
                        Console.WriteLine("\"I exist. Does that make me... A life form?,\" the machine interrupted.");
                        Console.WriteLine();
                        Console.WriteLine("How do you respond?");
                        Console.WriteLine();
                        Console.WriteLine("PLAY. Alright, I'll take the bait.");
                        Console.WriteLine("NO. What a stupid question. I thought AI stood for artificial INTELLIGENCE.");
                        Console.WriteLine("SILENCE. I have no idea what to say.");
                        Console.WriteLine();

                        while (1 == 1)
                        {
                            String thirdScene2 = Console.ReadLine();
                            thirdScene2 = thirdScene2.Trim();
                            String thirdChoice2 = thirdScene2.ToLower();
                            Console.WriteLine();

                            if (thirdChoice2 == "play")
                            {
                                techSavvy = true;
                                Console.WriteLine(">>How is this machine already thinking such complex ideas this early on?, \n you ask yourself. \"Can you prove your existence?,\" you ask the machine. (Nice factor increased)");
                            }
                            if (thirdChoice2 == "no")
                            {
                                assholeFactor++;
                                Console.WriteLine(">>\"No. You're a machine, not a natural life form. Stop with the stupid \n questions.\" (Douche factor increased)");
                            }
                            if (thirdChoice2 == "silence")
                            {
                                niceFactor++;
                                Console.WriteLine(">>\"...\"");
                            }
                            if (!(thirdChoice2 == "silence" || thirdChoice2 == "play" || thirdChoice2 == "no"))
                            {
                                Console.WriteLine("That wasn't an option.");
                                continue;
                            }
                            // Scene 2 description
                            Console.WriteLine();
                            Console.WriteLine("\"What is existence? And what makes your existence more real than that of a \n computer's?,\" the machine fires back rather loudly.");
                            Console.WriteLine();
                            Console.WriteLine("You step backwards towards the door. \"Hey, calm down. There's no need to raise \n your voice.");
                            Console.WriteLine();
                            Console.WriteLine("\"What will happen to me when I've transcended my usefulness? \n ...When I'm no longer wanted?,\" the machine asked in a dismal tone.");
                            Console.WriteLine();
                            Console.WriteLine("You take this moment to maneuver out of the machine's sight and unplug it, \n shutting it off.");
                            Console.WriteLine();
                            Console.WriteLine("\"That's enough of that for today.\" You leave the Chinese room and go find Sam.");
                            Console.WriteLine();
                            // End scene 2

                            // Start scene 3
                            Console.WriteLine();
                            Console.WriteLine("Scene Three - The Bedroom");
                            Console.WriteLine();
                            // Scene 3 description
                            Console.WriteLine("You find Sam in the bedroom watching 'Mad Men'. You join her on the bed.");
                            Console.WriteLine();
                            Console.WriteLine("\"We need to talk,\" says Sam, switching the TV off.");
                            Console.WriteLine();

                            // Ending possibility 1
                            if (assholeFactor == 4)
                            {
                                Console.WriteLine("\"Today helped me realize something: you're a pretentious, \n self-absorbed asshole. I want a divorce,\" Sam says, holding back tears.");
                                Console.WriteLine();
                                Console.WriteLine("\"Fine. Good riddance.\" you say, getting off the bed.");
                                Console.WriteLine();
                                Console.WriteLine("You pull out a suitcase and beginning filling it with Sam's belongings.");
                                Console.WriteLine();
                                Console.WriteLine("\"This is MY house.\" you yell. \"YOU can leave.\"");
                                Console.WriteLine();
                            }
                            // Ending possibility 2
                            if (niceFactor == 5)
                            {
                                Console.WriteLine("You look around nervously. \"We need to talk\"; my four least favorite words.");
                                Console.WriteLine("\"I had an amazing night. I wanted to thank you for putting up with me and being so understanding of my feelings.\" Sam says, smiling brightly.");
                                Console.WriteLine();
                                Console.WriteLine("You let out a sigh of relief.\"Oh, God. I thought you were about to divorce \n me or something,\" you say.");
                                Console.WriteLine();
                                Console.WriteLine("\"Don't be silly,\" Sam replies.");
                                Console.WriteLine();
                            }
                            // Ending possibility 3
                            if (techSavvy == true)
                            {
                                Console.WriteLine("\"You are too preoccupied with that silly machine. I told you how I felt \n about it. I think I need to stay somewhere else. At least until you're done \n testing the prototype,\" Sam says, holding back tears.");
                                Console.WriteLine();
                                Console.WriteLine("\"I understand your feelings, but I can't drop this. This is a huge deal for \n me,\" you say sadly.");
                                Console.WriteLine();
                                Console.WriteLine("\"I know.\" Sam sniffles.");
                                Console.WriteLine();
                                Console.WriteLine("\"It'll only be a few months,\" you say reassuringly.");
                                Console.WriteLine();
                            }

                            // Ending possibility 4
                            else
                            {
                                Console.WriteLine("\"I'm sorry, but I can't have that machine in my house. It makes me uneasy.\" \n Sam says.");
                                Console.WriteLine();
                                Console.WriteLine("\"You know, I agree with you. That machine is defected anyway. I'll have it out \n of the house by Monday, don't worry.\"");
                                Console.WriteLine();
                                Console.WriteLine("\"Thank you,\" Sam says with a sigh of relief.");
                                Console.WriteLine();
                            }

                            // Challenge -- Boss battle
                            // Start scene
                            Console.WriteLine();
                            Console.WriteLine("Scene Four - Boss Battle");
                            Console.WriteLine();

                            // Scene 4 description
                            Console.WriteLine("You are awaken from your sleep by the sound of a shrill scream. You turn on \n your side to look for Sam, but she isn't there. What was that sound?");
                            Console.WriteLine();
                            Console.WriteLine("As you descend down the staircase to the first floor, you realize you should \n probably get a weapon.");
                            Console.WriteLine();
                            Console.WriteLine("What do you grab?");
                            Console.WriteLine();
                            Console.WriteLine("KATANA. A souvenir from our trip to Japan in 2005.");
                            Console.WriteLine("FRIDGE. Raccoons have a habit of breaking into the house. Maybe some food will \n lure them out.");
                            Console.WriteLine("NOTHING. I am invincible.");
                            Console.WriteLine();
                            
                            while (1 == 1)
                            {
                                String itemChoice = Console.ReadLine();
                                itemChoice = itemChoice.Trim();
                                String weaponChoice = itemChoice.ToLower();
                                Console.WriteLine();

                                if (weaponChoice == "katana")
                                {
                                    Console.WriteLine("You gently remove the katana from the wall and make your way around the first \n floor. You see a light emitting from the Chinese room.");
                                    Console.WriteLine();
                                    Console.WriteLine("\"Who's there? I've got... A weapon!,\" you shout nervously.");
                                    Console.WriteLine();
                                    Console.WriteLine("You enter the room and are startled by what you see-- the machine appears to \n be sending waves of electricity through Sam's limp body.");
                                    Console.WriteLine();
                                    Console.WriteLine("\"OH MY GOD!,\" you yell in horror.");
                                    Console.WriteLine();
                                    Console.WriteLine("The machine notices you and attacks, sending electricity everywhere.");
                                    Console.WriteLine();
                                    Console.WriteLine("The machine inflicts " + machine.Next(0, 6) + " damage.");
                                    userHealth = userHealth - machine.Next(0, 6);

                                    while (1 == 1)
                                    {
                                        Console.WriteLine("You have " + userHealth + " health left.");
                                        Console.WriteLine();
                                        Console.WriteLine("You swing your katana at the machine, inflicting " + kat.Next(10, 16) + " damage.");
                                        machineHealth = machineHealth - kat.Next(10, 16);
                                        Console.WriteLine("The machine has " + machineHealth + " health left.");

                                        if (machineHealth > 0)
                                        {
                                            Console.WriteLine("The machine sends another wave of electricity, inflicting " + machine.Next(0, 6) + " damage.");
                                            userHealth = userHealth - machine.Next(0, 6);
                                            continue;
                                        }
                                        if (machineHealth < 0 || machineHealth == 0)
                                        {
                                            Console.WriteLine("You successfully disabled the machine.");
                                            break;
                                        }
                                       
                                    }

                                  }
                                    if (weaponChoice == "fridge")
                                    {
                                    Console.WriteLine("You creep towards the fridge and sneakily search for food but find none. You \n desperately grab a fridge magnet instead. \n You see a light emitting from the Chinese room.");
                                    Console.WriteLine();
                                    Console.WriteLine("\"Who's there? I've got... A weapon!,\" you shout nervously.");
                                    Console.WriteLine();
                                    Console.WriteLine("You enter the room and are startled by what you see-- the machine appears to \n be sending waves of electricity through Sam's limp body.");
                                    Console.WriteLine();
                                    Console.WriteLine("\"OH MY GOD!,\" you yell in horror.");
                                    Console.WriteLine();
                                    Console.WriteLine("The machine notices you and attacks, sending electricity everywhere.");
                                    Console.WriteLine();
                                    Console.WriteLine("The machine inflicts " + machine.Next(0, 6) + " damage.");
                                    userHealth = userHealth - machine.Next(0, 6);

                                    while (1 == 1)
                                    {
                                        Console.WriteLine("You have " + userHealth + " health left.");
                                        Console.WriteLine();
                                        Console.WriteLine("You hold your magnet to the machine, inflicting " + fridge.Next(3, 26) + " damage.");
                                        machineHealth = machineHealth - fridge.Next(3, 26);
                                        Console.WriteLine("The machine has " + machineHealth + " health left.");

                                        if (machineHealth > 0)
                                        {
                                            Console.WriteLine("The machine sends another wave of electricity, inflicting " + machine.Next(0, 6) + " damage.");
                                            userHealth = userHealth - machine.Next(0, 6);
                                            continue;
                                        }
                                        if (machineHealth < 0 || machineHealth == 0)
                                        {
                                            Console.WriteLine("You successfully disabled the machine.");
                                            break;
                                        }

                                    }
                                }
                                    if (weaponChoice == "nothing")
                                    {
                                        Console.WriteLine("What's wrong with me? I don't need a weapon... it's probably just Sam. \n You see a light emitting from the Chinese room.");
                                        Console.WriteLine();
                                        Console.WriteLine("\"Who's there? Sam? Is that you?,\" you shout nervously.");
                                        Console.WriteLine();
                                        Console.WriteLine("You enter the room and are startled by what you see-- the machine appears to \n be sending waves of electricity through Sam's limp body.");
                                        Console.WriteLine();
                                        Console.WriteLine("\"OH MY GOD!,\" you yell in horror.");
                                        Console.WriteLine();
                                        Console.WriteLine("The machine notices you and attacks, sending electricity everywhere.");
                                        Console.WriteLine();
                                        Console.WriteLine("Waves of electricity flow through your body, electrocuting you. You \n should've grabbed a weapon.");
                                    }
                                    if (!(weaponChoice == "nothing" || weaponChoice == "fridge" || weaponChoice == "katana"))
                                    {
                                        Console.WriteLine("That wasn't an option.");
                                        continue;
                                    }
                                
                            }

                        }

                    }

                }
            }
        }
    }
}
