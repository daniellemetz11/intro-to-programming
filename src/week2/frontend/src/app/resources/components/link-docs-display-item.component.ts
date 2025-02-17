import { Component, ChangeDetectionStrategy } from '@angular/core';
import { ResourceListItem } from '../types';

@Component({
  selector: 'app-link-docks-display-item',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: `
    <div class="card bg-neutral text-neutral-content w-96">
      <div class="card-body items-center text-center">
        <h2 class="card-title">Documentation: {{ link().title }}</h2>
        <p>{{ link().description }}</p>
        <div class="card-actions justify-end">
          <a class="btn btn-link" [href]="link().link" target="_blank">{{
            link().linkText
          }}</a>
          <div>
            @for (tag of link().tags; track $index) {
              <div class="badge badge-secondary badge-outline">
                {{ tag }}
              </div>
            }
          </div>
        </div>
      </div>
    </div>
  `,
  styles: ``,
})
export class LinkDocsDisplayItemComponent {}
