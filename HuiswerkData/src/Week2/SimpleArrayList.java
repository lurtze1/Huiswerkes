package Week2;

/**
 * Created by lurtze1 on 14-Sep-16.
 */
interface SimpleArrayList {
    void add(int n); // toevoegen aan het einde van de lijst, mits de lijst niet vol is

    int get(int index); // haal de waarde op van een bepaalde index

    void set(int index, int n); // wijzig een item op een bepaalde index

    void print(); // print de inhoud van de list

    void clear(); // maak de list leeg

    int countOccurences(int n); // tel hoe vaak het gegeven getal voorkomt
}