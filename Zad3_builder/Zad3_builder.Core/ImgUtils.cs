using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;

namespace Zad3_builder.Core;
public class ImgUtils
{

    /**
     * Laduje i zwraca obraz z katalogu /img/ w resources
     * @param imgName nazwa pliku
     * @return zaladowany obraz
     */
    public static Image getImage(String imgName)
    {
        InputStream fileName = ImgUtils.class.getResourceAsStream("/img/"+imgName);
    BufferedImage img;
        try {
            img = ImageIO.read(fileName);
        } catch (IOException ex) {
            Logger.getLogger(ImgUtils.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
        return img;
    }
}