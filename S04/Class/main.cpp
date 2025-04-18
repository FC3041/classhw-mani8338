#include<iostream>
#include<cmath>


class Point{
    public:
        double m_x;
        double m_y;

        Point(){};

        Point(double x,double y):m_x(x),m_y(y){};

        void print_point()
        {
            std::cout<<"x: " <<m_x<<" ,y: "<<m_y<<std::endl;
        }
        double DistanceTo(const Point& p)
        {
            double x_diff = m_x - p.m_x;
            double y_diff = m_y - p.m_y;
            return sqrt(x_diff*x_diff+y_diff*y_diff);
        }
};

class Circle{
    public:
        Point m_O;
        double m_r;

        // Circle(const Point& O,double r)
        // {
        //     m_O = O;
        //     m_r = r;
        // }

        //seconde way to create a constructor
        Circle(const Point& O,double r):m_O(O),m_r(r){};

        Circle(){};

        double DistanceTo(const Circle& c) 
        {
            return DistanceTo(c.m_O);
        }
        double DistanceTo(Point p)
        {
            return p.DistanceTo(m_O);
        }

};

int main()
{
    Point p1;
    Point p2(4,7);
    Point p3(1,5);

    Circle c1(p1,12.3);
    Circle c2(p3,12);

    std::cout << c1.DistanceTo(c2) << std::endl;
    std::cout << c1.DistanceTo(p1) << std::endl;
    std::cout << p1.DistanceTo(p2) << std::endl;

    return 0;
}