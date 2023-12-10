import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

export class AppComponent implements OnInit{
  title='Social Apps';
  users:any;
  constructor(private http:HttpClient){}
  ngOnInit(): void {
    this.http.get<any>('https://localhost:5001/api/users').subscribe({
      next:(res) => {
        this.users=res;
        console.log(res);

      }, error:(err)=> {
        console.log(err);

      }, complete: () => {
        console.log('Request Completed');
      }
    })
    
  }
}

