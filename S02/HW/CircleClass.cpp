#include<iostream>
#include<cmath>

using namespace std;

bool near(double x,double y){
    double min;
    if(y >= x){
        min = x;
    }
    else{
        min = y;
    }
    double clossness = min * 0.01;
    if(abs(x-y) <= clossness){
        return true;
    }else{
        return false;
    }
}
class Point{
    public:
    double x;
    double y;
    
    double points_distance(Point p)
    {
        double disX = p.x - x;
        double disY = p.y - y;
        return sqrt(disX*disX+disY*disY);
    }
};

class Circle{
    public:
        double r;
        Point O;

    double distance_from_center(Point p) 
    {
        return O.points_distance(p);
    }
    double Perimeter()
    {
        return 2*r*M_PI;
    }
    double Surface()
    {
        return r*r*M_PI;
    }
    string inside_the_circle(Point p)
    {
        double dis = distance_from_center(p);
        if(dis > r){
            return "outside";
        }
        else if(near(dis,r)){
            return "on";
        }else{
            return "inside";
        }  
    }
    double center_distance_between_two_circles(Circle c)
    {
        return O.points_distance(c.O);
    }
        

};

int main()
{
    Point p1;
    p1.x = 4;
    p1.y = 5;

    Point p2;
    p2.x = -1.9;
    p2.y = 13.765;

    Point p3;
    p3.x = 5.3;
    p3.y = 8.41;

    Circle c2;
    c2.r = 3;
    c2.O.x = 1;
    c2.O.y = 10;

    Circle c1;
    c1.r = 5;
    c1.O.x = 4;
    c1.O.y = 3;

    Circle c3;
    c3.O.x = 3.43;
    c3.O.y = 8.41;
    c3.r = 1.87;

    c1.inside_the_circle(p1);
    double P = c1.Perimeter();
    double S = c1.Surface();
    double dis = c1.distance_from_center(p1);
    double disOC = c1.center_distance_between_two_circles(c2);

    cout << "Perimeter of circle c1 is " << P << endl;
    cout << "Surface of circle c1 is " << S << endl;
    cout << "distance between the center of the circle c1 and point p1 is "<<dis<<endl;
    cout << "the distance between the ceneters of the circles c1 and c2 is " << disOC << endl;
    if(c1.inside_the_circle(p1) == "inside"){
        cout << "point p1 is inside of c1" << endl << endl;
    }
    else if(c1.inside_the_circle(p1) == "on"){
        cout << "point p1 is on c1" << endl << endl;
    }else{
        cout << "point p1 is outside of c1" << endl << endl;
    }


    if(c1.inside_the_circle(p2) == "inside"){
        cout << "point p2 is inside of the circle" << endl << endl;
    }
    else if(c1.inside_the_circle(p2) == "on"){
        cout << "point p2 is on the circle" << endl<< endl;
    }else{
        cout << "point p2 is outside of the circle" << endl<< endl;
    }

    
    cout << "P3 = "<<c3.Perimeter()<<endl;
    cout << "S3 = "<<c3.Surface()<<endl;
    cout << "O1O3 = "<<c3.center_distance_between_two_circles(c1) << endl;
    cout << "O3p3 = "<<c3.distance_from_center(p3)<<endl;
    if(c3.inside_the_circle(p3) == "inside"){
        cout << "point p1 is inside of c3" << endl << endl;
    }
    else if(c3.inside_the_circle(p3) == "on"){
        cout << "point p2 is on c3" << endl << endl;
    }else{
        cout << "point p1 is outside of c3" << endl << endl;
    }
    return 0;
}