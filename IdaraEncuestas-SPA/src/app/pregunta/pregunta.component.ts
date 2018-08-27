import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-pregunta',
  templateUrl: './pregunta.component.html',
  styleUrls: ['./pregunta.component.css']
})
export class PreguntaComponent implements OnInit {
  preguntas: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getPreguntas();
  }

  getPreguntas() {
    this.http.get('http://localhost:5000/api/preguntas').subscribe(response => {
      this.preguntas = response;
    }, error => {
      console.log(error);
    });
  }
}
