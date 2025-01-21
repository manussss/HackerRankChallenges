namespace ProgrammingChallenges.HackerRank;

public static class DrawingBook
{
    /*
    A student can either start turning pages from the front of the book or from the back of the book
    They turn 1 page at a time

    Open page 1, wants to get to page 3, book has total of 5 pages

    front = avança 2 paginas por vez, dividir por 2
    back = se impar, ultima pagina - pagina alvo e divide por 2
           se par, adicionar 1 pagina, tera mais 1 virada
     
     */
    public static int GetPagesTo(int bookPages, int targetPage)
    {
        var front = targetPage / 2;
        var back = bookPages % 2 == 1 ? (bookPages - targetPage) / 2 : (bookPages - targetPage + 1) / 2;

        return Math.Min(front, back);
    }
}
