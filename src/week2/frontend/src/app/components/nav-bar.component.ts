import { Component, ChangeDetectionStrategy, signal } from '@angular/core';
import { RouterLink } from '@angular/router';
import { LoginStatusComponent } from './login-status.component';

@Component({
  selector: 'app-nav-bar',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [RouterLink, LoginStatusComponent],
  template: `
    <div class="navbar bg-base-100">
      <div class="navbar-start">
        <div class="dropdown">
          <div tabindex="0" role="button" class="btn btn-ghost lg:hidden">
            <svg
              xmlns="http://www.w3.org/2000/svg"
              class="h-5 w-5"
              fill="none"
              viewBox="0 0 24 24"
              stroke="currentColor"
            >
              <path
                stroke-linecap="round"
                stroke-linejoin="round"
                stroke-width="2"
                d="M4 6h16M4 12h8m-8 6h16"
              />
            </svg>
          </div>
          <ul
            tabindex="0"
            class="menu menu-sm dropdown-content bg-base-100 rounded-box z-[1] mt-3 w-52 p-2 shadow"
          >
            @for (link of links(); track link.path) {
              <li>
                <a [routerLink]="link.path">{{ link.text }}</a>
              </li>
            }
          </ul>
        </div>
        <a routerLink="" class="btn btn-ghost text-xl">Angular App</a>
      </div>
      <div class="navbar-center hidden lg:flex">
        <ul class="menu menu-horizontal px-1">
          @for (link of links(); track link.path) {
            <li>
              <a [routerLink]="link.path">{{ link.text }}</a>
            </li>
          }
        </ul>
      </div>
      <div class="navbar-end"><app-login-status /></div>
    </div>
  `,
  styles: ``,
})
export class NavBarComponent {
  links = signal([
    { path: 'banking', text: 'Banking' },
    { path: 'resources', text: 'Developer Resources' },
    { path: 'counter', text: 'Counter Demo' },
  ]);
}
