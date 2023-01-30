//Вычисляем, сколько раз собака пробежит между друзьями, пока они не встретятся, идя навстречу друг другу:
int count = 0;
double distance = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;
int friend = 2;
double time = 0;
double timeAll = 0;
while (distance > 10){
	if (friend == 1){
		time = distance / (FirstFriendSpeed + DogSpeed);
		friend = 2;
    }
	else{
		time = distance / (SecondFriendSpeed + DogSpeed);
		friend = 1;
    }        
	distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
    // timeAll += time;        // общее время собачьего бега
    // Console.WriteLine(distance);        // оставшаяся дистанция после очередного пробега
	count = count + 1;
}    
Console.WriteLine(count);
// Console.WriteLine(timeAll / 60);        // общее время собачьего бега = время, через которое друзья встретятся
// Console.WriteLine(10000 / 3 / 60);      // время, через которое друзья встретятся
// Вывод: 12
