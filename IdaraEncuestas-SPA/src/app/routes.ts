import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MemberListComponent } from './member-list/member-list.component';
import { CreateQuizComponent } from './create-quiz/create-quiz.component';
import { QuizComponent } from './quiz/quiz.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent},
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            { path: 'miembros', component: MemberListComponent},
            { path: 'crearCuestionario', component: CreateQuizComponent},
            { path: 'cuestionario', component: QuizComponent},
        ]
    },
    { path: '**', redirectTo: '', pathMatch: 'full'},
];
