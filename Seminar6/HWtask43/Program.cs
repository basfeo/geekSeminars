const int POINT_ON_THE_COORDINATE_LINE1 = 0;
const int POINT_ON_THE_COORDINATE_LINE2 = 1;
const int LINE1 = 0;
const int LINE2 = 1;
const int INTERSECTION_POINT_X = 0;
const int INTERSECTION_POINT_Y = 1;

double Prompt(string mssg){
    Console.WriteLine(mssg);
    return Convert.ToInt32(Console.ReadLine());
}

double[] InputLineData(int NumberLineConst){
    double[] LineData = new double[2];
    LineData[POINT_ON_THE_COORDINATE_LINE1] = Prompt("Input point on the coordinate line 1");
    LineData[POINT_ON_THE_COORDINATE_LINE2] = Prompt("Input point on the coordinate line 2");
    return LineData;
}

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

bool Validate(double[] lineData1, double[] lineData2){
    if (lineData1[POINT_ON_THE_COORDINATE_LINE1] == lineData2[POINT_ON_THE_COORDINATE_LINE1]){
        if (lineData1[POINT_ON_THE_COORDINATE_LINE2] == lineData2[POINT_ON_THE_COORDINATE_LINE2]){
            Console.WriteLine("line split");
            return false;
        }
        else
        {
            Console.WriteLine("line parall");
            return false;
        }
    }
    return true;
}

double[] FineCoord(double[] lineData1, double[] lineData2){
    double[] out_res = new double[2];

    out_res[INTERSECTION_POINT_X] = (lineData2[POINT_ON_THE_COORDINATE_LINE1] - lineData1[POINT_ON_THE_COORDINATE_LINE1]) / (lineData1[POINT_ON_THE_COORDINATE_LINE2] - lineData2[POINT_ON_THE_COORDINATE_LINE2]);
    out_res[INTERSECTION_POINT_Y] = lineData1[POINT_ON_THE_COORDINATE_LINE2] * out_res[INTERSECTION_POINT_X] + lineData1[POINT_ON_THE_COORDINATE_LINE1];
    return out_res;
}

if (Validate(lineData1, lineData2)){
    double[] coord = FineCoord(lineData1, lineData2);
    Console.WriteLine($"Точка пересечения имеет координаты {coord[INTERSECTION_POINT_X]},{coord[INTERSECTION_POINT_Y]}");
}