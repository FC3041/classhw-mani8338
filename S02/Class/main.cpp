#include <iostream>
#include <cmath> 

using namespace std;

class Point{
public:
    double x;
    double y;

    Point(double t,double r)
    {
        x = t;
        y = r;
        cout << "x in c:" << x << ", y in x:" << y << endl;
    }

    Point(double w)
    {
        x = w;
        y = w;
    }

    //1st method
    // Point(Point* z)
    // {
    //     x = z->x;
    //     y = z->y;
    // }

    // Point(Point& q)
    // {
    //     x = q.x;
    //     q.y++;
    //     y = q.y;
    // }

    Point(const Point& q) //const correctness
    {
        x = q.x;
        y = q.y;
    }

    void print_point()
    {
        cout << "x: " << x << ", y: " << y << endl;
    }
    double points_distance(Point w)
    {
        double dis = (w.x - x)*(w.x - x) + (w.y - y)*(w.y - y);
        dis = sqrt(dis);
        return dis;
    }

    ~Point(){
        cout << "x in d:" << x << ", y in d:" << y << endl;
    }
};

int main()
{
    Point p1(1,1);
    int c = 5;
    if(c > 3){
        Point p2(2,2);
    }else{
        Point p3(3,3);
    }
}

int main1() {
    //Point p1;
    // p1.x = 4;
    // p1.y = 5;

    Point p1(4,5);
    Point p0(9);
    p0.print_point();

    // Point p2;
    // p2.x = -5;
    // p2.y = 10;

    Point p2(-5,10);

    p1.print_point();
    p2.print_point();

    Point p3(p2);
    p3.print_point();
    

    double r = p1.points_distance(p2);  
    cout << r << endl;

    // cout << p1.x << endl;

    // int a;
    // cin >> a;
    // cout << "a:" << a << endl;

    return 0; 
}
