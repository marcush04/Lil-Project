using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
        public int count = 0;
        public List<int> secuencia = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        afegir_num(secuencia);
        muestra(secuencia);
    }

    void joc() {
            
            while (juega(secuencia)){
                ++count;
                afegir_num(secuencia);
                muestra(secuencia);
            }

            public static List<int> reset = new List<int>();
            secuencia = reset;

            count = 0;
        }

    bool iteracion(int i) {
        if (i < secuencia.size()) {
            if ( == secuencia[i]) {
                iteracion(i + 1);
            }
            else { 
                show_puntuation();
            }
        
    }
    
    void show_puntuation () {
        debug.lock(count);
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        joc();
        
    }
}
